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
        private string CONNSTRING = System.Configuration.ConfigurationManager.ConnectionStrings["AirMonit_Service.Properties.Settings.DBConn"].ConnectionString;

        [Route("api/NO2")]
        public IEnumerable<NO> Get()
        {
            List<NO> lista = new List<NO>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM NO2";
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NO n = new NO();
                    n.value = (int)reader["value"];
                    n.date = (DateTime)reader["date"];
                    n.local = (string)reader["local"];
<<<<<<< HEAD
                    
=======

>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27

                    lista.Add(n);
                }

                conn.Close();
                reader.Close();
            }
            catch (Exception e)
            {
                throw e;

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

        [Route("api/{local}/NO2/{date}")]
        public IEnumerable<NO> GetSensorCityDate(string local, string date) //NOTA: date pode ser um Date e não um String? confirmar com grupo / ficheiro TODO
        {
            List<NO> lista = new List<NO>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
<<<<<<< HEAD
                cmd.CommandText = "SELECT * FROM NO WHERE date >= @datw AND date <= @date and local = @local";
                cmd.Parameters.AddWithValue("@date", date + "T00:00:00.000");
                cmd.Parameters.AddWithValue("@date", date + "T23:59:59.000");
=======
                if (local == "All")
                {
                    cmd.CommandText = "SELECT * FROM NO2 WHERE date >= @date AND date <= @date";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM NO2 WHERE date >= @date AND date <= @dateEnd and local = @local";
                }
                string[] tempsplit = date.Split('-');
                string joinstring = "-";
                string newdate = tempsplit[2] + joinstring + tempsplit[1] + joinstring + tempsplit[0];
                cmd.Parameters.AddWithValue("@date", newdate + "T00:00:00.000");
                cmd.Parameters.AddWithValue("@dateEnd", newdate + "T23:59:59.000");
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
                cmd.Parameters.AddWithValue("@local", local);

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

        [Route("api/{local}/NO2")]
<<<<<<< HEAD
        public IEnumerable<NO> GetSensorCity(string local) //NOTA: date pode ser um Date e não um String? confirmar com grupo / ficheiro TODO
=======
        public IEnumerable<NO> GetSensorCity(string local)
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
        {
            List<NO> lista = new List<NO>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
<<<<<<< HEAD
                cmd.CommandText = "SELECT * FROM NO WHERE local = @local";
=======
                if (local == "All")
                {
                    cmd.CommandText = "SELECT * FROM NO2";
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM NO2 WHERE local = @local";
                }
>>>>>>> 29802e09e4080cf1f0c9b55b25512b2a138dbc27
                cmd.Parameters.AddWithValue("@local", local);

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
