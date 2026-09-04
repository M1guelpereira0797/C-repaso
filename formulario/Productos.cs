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
            CargarProductos();
        }

        private void Producto_Load(object sender, EventArgs e)
        {


        }

        public void CargarProductos()
        {
            string ConectarString = @"Server=(localdb)\MSSQLLocalDB;Database=PruebaBD;Trusted_Connection=True;";
            List<formulario.Entidades.Producto> Lista_Producto = new List<formulario.Entidades.Producto>();
            var Query = "SELECT * FROM Producto";

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
                                formulario.Entidades.Producto p = new formulario.Entidades.Producto();
                                p.Id = Convert.ToInt32(LeerBD["Id"]);
                                p.Descripciones = LeerBD["Descripciones"].ToString();
                                p.Costo = Convert.ToDouble(LeerBD["Costo"]);
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
            if (cmbBx.Text == "Maipu" || cmbBx.Text == "Carlos Valdovinos" || cmbBx.Text == "Puente Alto" || cmbBx.Text == "Renca")
            {
                CargarProductos();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto formulario = new AgregarProducto();
            formulario.ShowDialog();
           

        }
    }
}
 
