using AirMonit_Service.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AirMonit_Service.Controllers
{
    public class NOController : ApiController
    {
        private string CONNSTRING = System.Configuration.ConfigurationManager.ConnectionStrings["AirMonit_Service.Properties.Settings.ConnString"].ConnectionString;

        public IEnumerable<NO> GetAllProducts()
        {
            List<NO> lista = new List<NO>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM NO";
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NO n = new NO();
                    n.value = (int)reader["value"];
                    n.date = (DateTime)reader["date"];
                    n.local = (string)reader["local"];
                    

                    lista.Add(n);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return lista;
        }
    }


}
