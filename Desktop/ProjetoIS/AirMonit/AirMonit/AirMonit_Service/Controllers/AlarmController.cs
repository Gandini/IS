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
    public class AlarmController : ApiController
    {
        private string CONNSTRING = System.Configuration.ConfigurationManager.ConnectionStrings["AirMonit_Service.Properties.Settings.ConnString"].ConnectionString;

        public IEnumerable<Alarm> GetAllProducts()
        {
            List<Alarm> lista = new List<Alarm>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Alarm";
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Alarm n = new Alarm();
                    n.value = (int)reader["value"];
                    n.molecule = (string)reader["molecule"];
                    n.errorMessage = (string)reader["errorMessage"];


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
