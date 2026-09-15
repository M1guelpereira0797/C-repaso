using System;
using System.Collections.Generic;
using System.Text;
using AppEntidades;
using Microsoft.Data.SqlClient;

namespace AppDataBase
{
    public class CentrosData
    {

        public List<CENTRO_LOGISTICO> GetCentros()
        {
            string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=PROYECTOBD2;Trusted_Connection=True;";
            List<CENTRO_LOGISTICO> Centros = new List<CENTRO_LOGISTICO>();
            var ConsultaQuery = "SELECT * FROM CENTRO_LOGISTICO";
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ManejadorBD = new SqlCommand(ConsultaQuery, ConectarBD))
                {
                    using (SqlDataReader LeerDatos = ManejadorBD.ExecuteReader())
                    {
                        if (LeerDatos.HasRows)
                        {
                            while (LeerDatos.Read())
                            {
                                CENTRO_LOGISTICO centro = new CENTRO_LOGISTICO();
                                centro.CENTRO_LOGISTO_ID = Convert.ToInt32(LeerDatos["CENTRO"]);
                                centro.NOMBRE_CENTRO = LeerDatos["NOMBRE"].ToString();
                                Centros.Add(centro);
                            }
                        }

                    }
                    ConectarBD.Close();
                }
                return Centros;
            }
        }
       
        public static CENTRO_LOGISTICO CentroById(int centroID) // o renombrar a CentroById
        {
            string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=PROYECTOBD2;Trusted_Connection=True;";
            var ConsultaQuery = "SELECT * FROM CENTRO_LOGISTICO WHERE Centro_ID = @Centro_ID";
            using (SqlConnection ConectarBD = new SqlConnection(ConnectionString))
            {
                ConectarBD.Open();
                using (SqlCommand ManejadorBD = new SqlCommand(ConsultaQuery, ConectarBD))
                {
                    ManejadorBD.Parameters.AddWithValue("@Centro_ID", centroID);
                    using (SqlDataReader LeerDatos = ManejadorBD.ExecuteReader())
                    {
                        if (LeerDatos.Read())
                        {
                            CENTRO_LOGISTICO centro = new CENTRO_LOGISTICO();
                            centro.CENTRO_LOGISTO_ID = Convert.ToInt32(LeerDatos["CENTRO_LOGISTICO_ID"]);
                            centro.NOMBRE_CENTRO = LeerDatos["Nombre_Centro"].ToString();
                            return centro;
                        }
                        throw new Exception("ID NO ENCONTRADO");
                    }
                }
            }
        }
    }
}
