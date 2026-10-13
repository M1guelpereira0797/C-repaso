using System;
using System.Collections.Generic;
using System.Text;
using AppEntidades;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace AppDataBase
{
    public class UsuarioData
    {
        public List<Usuario> GetUsuarios()
        {
            string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BASEDEDATONEW;Trusted_Connection=True;";
            var queryInvocar = "SELECT * FROM REGISTROUSUARIO ";
            List<Usuario> UsuariosTraer = new List<Usuario>();
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand TraerUsuarios = new SqlCommand(queryInvocar, ConectarBD))
                {
                    using (SqlDataReader LeerUsuarios = TraerUsuarios.ExecuteReader())
                    {
                        if (LeerUsuarios.HasRows)
                        {
                            while (LeerUsuarios.Read())
                            {
                                Usuario usuario = new Usuario();
                                usuario.ID_Usuario = Convert.ToInt32(LeerUsuarios["ID_Usuario"]);
                                usuario.Nombres = LeerUsuarios["Nombres"].ToString();
                                usuario.Apellido_Paterno = LeerUsuarios["Apellido_Paterno"].ToString();
                                usuario.Apellido_Materno = LeerUsuarios["Apellido_Materno"].ToString();
                                usuario.CorreoElectronico = LeerUsuarios["CorreoElectronico"].ToString();
                                usuario.Contraseña = Convert.ToInt32(LeerUsuarios["Contraseña"]);
                                usuario.Fecha_de_Nacimiento = Convert.ToDateTime(LeerUsuarios["Fecha_de_Nacimiento"]);
                                usuario.Sexo = LeerUsuarios["Sexo"].ToString();
                                usuario.Rut = Convert.ToInt32(LeerUsuarios["Rut"]);
                                UsuariosTraer.Add(usuario);





                            }

                        }
                    }
                    ConectarBD.Close();
                }
                return UsuariosTraer;
            }


        }
        public static void BontonAgregarUsuario(Usuario usuario)
        {
            string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BASEDEDATONEW;Trusted_Connection=True;";
            var queryAgregrar = "INSERT INTO REGISTROUSUARIO (ID_Usuario, Nombres, Apellido_Parterno, Apellido_Materno, Correo_Electronico, Contraseña, Fecha_de_Nacimiento, Sexo, Rut)" +
                " VALUES (@ID_Usuario, @Nombres, @Apellido_Parterno, @Apellido_Materno, @Correo_Electronico, @Contraseña, @Fecha_de_Nacimiento, @Sexo, @Rut) ";
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ComandoAgregar = new SqlCommand(queryAgregrar, ConectarBD))
                {
                    ComandoAgregar.Parameters.AddWithValue("@ID_Usuario",usuario.ID_Usuario);
                    ComandoAgregar.Parameters.AddWithValue("@Nombres", usuario.Nombres);
                    ComandoAgregar.Parameters.AddWithValue("@Apellido_Parterno", usuario.Apellido_Paterno);
                    ComandoAgregar.Parameters.AddWithValue("@Apellido_Materno", usuario.Apellido_Materno);
                    ComandoAgregar.Parameters.AddWithValue("@Correo_Electronico", usuario.CorreoElectronico);
                    ComandoAgregar.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                    ComandoAgregar.Parameters.AddWithValue("@Fecha_de_Nacimiento", usuario.Fecha_de_Nacimiento);
                    ComandoAgregar.Parameters.AddWithValue("@Sexo", usuario.Sexo);
                    ComandoAgregar.Parameters.AddWithValue("@Rut", usuario.Rut);
                    ComandoAgregar.ExecuteNonQuery();
                }
                ConectarBD.Close();
            }
        }
        public static bool ValidarUsuario(Usuario usuario)
        {
            string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BASEDEDATONEW;Trusted_Connection=True;";
            var QueryValidar = "SELECT COUNT(*) FROM REGISTROUSUARIO WHERE CORREO_ELECTRONICO = @Correo_Electronico AND CONTRASEÑA = @Contraseña"; ;
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ComandoValidar  = new SqlCommand(QueryValidar, ConectarBD))
                {
                    ComandoValidar.Parameters.AddWithValue("@Correo_Electronico", usuario.CorreoElectronico);
                    ComandoValidar.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

                    int cantidad = Convert.ToInt32(ComandoValidar.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }
        public static bool CorreoExiste(string correoElectronico)
        {
            string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BASEDEDATONEW;Trusted_Connection=True;";
            string QueryCorreo = "SELECT COUNT(*) FROM REGISTROUSUARIO WHERE CORREO_ELECTRONICO = @Correo_Electronico";
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ComandoCorreo = new SqlCommand(QueryCorreo, ConectarBD))
                {
                    ComandoCorreo.Parameters.AddWithValue("@Correo_Electronico", correoElectronico);
                    int cantidad = Convert.ToInt32(ComandoCorreo.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }
    }
}
     
 
       
     