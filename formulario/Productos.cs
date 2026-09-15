using System.Data;
using System.Data.SqlClient;
using formulario;
using formulario.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

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
            CargarDEproductos();

        }
        public void CargarDEproductos()
        {
            List<Producto> Lista_Producto = CargarProductos();
            dataGridView1.DataSource = Lista_Producto;
            dataGridView1.AutoGenerateColumns = true;
        }
        public static List<Producto> CargarProductos()
        {
            string ConectarString = @"Server=(localdb)\MSSQLLocalDB;Database=PROYECTOBD2;Trusted_Connection=True;";
            List<Producto> Lista_Producto = new List<Producto>();
            var Query = "SELECT * FROM PRODUCTO";

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
                                p.Sku = Convert.ToInt32(LeerBD["SKU"]);
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
            return Lista_Producto;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int sku = Convert.ToInt32(BuscarIdTxt.Text);
            Producto producto = ProductoById(sku);

            List<Producto> lista = new List<Producto>();
            lista.Add(producto);

            dataGridView1.DataSource = lista;
            dataGridView1.AutoGenerateColumns = true;





        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgregarProducto formulario = new AgregarProducto();

            formulario.ShowDialog();
            



        }

        public void BorrarProducto(Producto prodcuto)
        {
            string ConectarString = @"Server=(localdb)\MSSQLLocalDB;Database=PROYECTOBD2;Trusted_Connection=True;";
            var query = "Delete From PRODUCTO Where SKU = @SKU";
            using (SqlConnection ConectarBD = new SqlConnection(ConectarString))

            {
                ConectarBD.Open();
                using (SqlCommand ProductoBorrar = new SqlCommand(query, ConectarBD))
                {
                    ProductoBorrar.Parameters.AddWithValue("@SKU", prodcuto.Sku);
                    ProductoBorrar.ExecuteNonQuery();

                }
                ConectarBD.Close();
            }

        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            BorrarProducto((Producto)dataGridView1.CurrentRow.DataBoundItem);

        }

        private void RefrescarBtn_Click(object sender, EventArgs e)
        {
            CargarDEproductos();
        }

        private void ActuailzarBtn_Click(object sender, EventArgs e)
        {
            AgregarProducto formulario = new AgregarProducto();

            formulario.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            AgregarProducto formulario = new AgregarProducto();

            formulario.ShowDialog();
        

        }

        public static Producto ProductoById(int sku)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=PROYECTOBD2;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PRODUCTO WHERE Sku = @sku";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sku", sku);
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    var producto = new Producto();
                    producto.Sku = Convert.ToInt32(dataReader["Sku"]);
                    producto.Descripcion = dataReader["Descripcion"].ToString();
                    producto.Litros = Convert.ToDouble(dataReader["Litros"]);
                    producto.Kilogramos = Convert.ToDouble(dataReader["Kilogramos"]);
                    producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);

                    return producto;
                }

                throw new Exception("ID NO ENCONTRADO");
            }
        }
    }
}



