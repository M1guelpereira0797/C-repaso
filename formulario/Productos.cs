using System.Data;
using System.Data.SqlClient;
using formulario;
using formulario.Entidades;
using Microsoft.Data.SqlClient;

namespace formulario
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();

           
        }

        private void Producto_Load(object sender, EventArgs e)
        {
                    CargarProductos();

        }
        public void CargarProductos()
         {
              string ConectarString = @"Server=(localdb)\MSSQLLocalDB;Database=PROYECTOBD;Trusted_Connection=True;";
              List<Producto> Lista_Producto = new List<Producto>();
              var Query = "SELECT * FROM PRODUCTOS";

              using (SqlConnection ConectarBd = new SqlConnection(ConectarString))
              {
                  ConectarBd.Open();
                  using (SqlCommand InstruccionBD = new SqlCommand(Query, ConectarBd))
                  {
                      using (SqlDataReader LeerBD = InstruccionBD.ExecuteReader())
                      {
                          if (LeerBD.HasRows)
                          {
                              while (LeerBD.Read())
                              {
                                  Producto p = new Producto();
                                  p.Sku= Convert.ToInt32(LeerBD["SKU"]);
                                  p.Descripcion = LeerBD["Descripcion"].ToString();
                                  p.Litros = Convert.ToDouble(LeerBD["Litros"]);
                                  p.Kilogramos = Convert.ToDouble(LeerBD["Kilogramos"]);
                                  p.PrecioVenta = Convert.ToDouble(LeerBD["PrecioVenta"]);
                                  Lista_Producto.Add(p);

                              }
                          }
                      }
                      ConectarBd.Close();
                  }
              }
              dataGridView1.DataSource = Lista_Producto;
              dataGridView1.AutoGenerateColumns = true;
          }
        
        private void BtnBuscar_Click(object sender, EventArgs e)
          {
            if( cmbBx.Text == "Maipu" || cmbBx.Text == "Puente alto" || cmbBx.Text == "Renca" || cmbBx.Text == "Carlos Valdovinos")
            {
                CargarProductos();
            }

           
        }

          private void BtnAgregar_Click(object sender, EventArgs e)
          {
            AgregarProducto formulario = new AgregarProducto();

            formulario.ShowDialog();

            CargarProductos();

        }
       

            
        }
    }



