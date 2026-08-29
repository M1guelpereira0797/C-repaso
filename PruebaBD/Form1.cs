using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace PruebaBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Connexion = @"Server=(localdb)\MSSQLLocalDB;Database=PruebaBD;Trusted_Connection=True;";

            string query = "SELECT * FROM Producto";

            List<Producto> listProductos = new List<Producto>();
            using (SqlConnection ConectarBD = new SqlConnection(Connexion))
            {
                ConectarBD.Open();
                using (SqlCommand Comando = new SqlCommand(query, ConectarBD))
                {
                    using (SqlDataReader leerBD = Comando.ExecuteReader())
                    {
                        if (leerBD.HasRows)
                        {
                            while (leerBD.Read())
                            {
                                Producto p = new Producto();
                                p.Id = Convert.ToInt32(leerBD["Id"]);
                                p.Descripcion = leerBD["Descripciones"].ToString();
                                p.Costo = Convert.ToDouble(leerBD["Costo"]);
                                p.PrecioVenta = Convert.ToDouble(leerBD["PrecioVenta"]);
                                listProductos.Add(p);

                            }
                        }
                    }
                    ConectarBD.Close();
                }
            }

            dataGridView1.DataSource = listProductos;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connexion = @"Server=(localdb)\MSSQLLocalDB;Database=PruebaBD;Trusted_Connection=True;";
            string query2 = "SELECT * FROM Usuario";

            List<Usuario> lista_Usuario = new List<Usuario>();
            using (SqlConnection ConectarBD = new SqlConnection(Connexion))
            {
                ConectarBD.Open();
                using (SqlCommand Comando = new SqlCommand(query2, ConectarBD))
                {
                    using (SqlDataReader leerBD = Comando.ExecuteReader())
                    {
                        if (leerBD.HasRows)
                        {
                            while (leerBD.Read())
                            {
                                Usuario u = new Usuario();
                                u.Nombre = leerBD["Nombre"].ToString();
                                u.Apellido = leerBD["Apellido"].ToString();
                                u.NombreUsuario = leerBD["NombreUsuario"].ToString();
                                u.Contraseña = leerBD["Contraseña"].ToString();
                                u.Mail = leerBD["Mail"].ToString();
                                lista_Usuario.Add(u);

                            }
                        }
                    }
                    ConectarBD.Close();
                }
            }
            dataGridView1.DataSource = lista_Usuario;
            dataGridView1.AutoGenerateColumns = true;
        }
    }
}
