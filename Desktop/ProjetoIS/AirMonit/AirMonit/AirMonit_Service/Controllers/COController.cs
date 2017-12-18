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
    public class COController : ApiController
    {
        private string CONNSTRING = System.Configuration.ConfigurationManager.ConnectionStrings["AirMonit_Service.Properties.Settings.DBConn"].ConnectionString;

        [Route("api/co")]
        public IEnumerable<CO> Get()
        {
            List<CO> lista = new List<CO>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM CO";
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CO n = new CO();
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

        [Route("api/{local}/CO/{date}")]
        public IEnumerable<CO> GetSensorCityDate(string local, string date) //NOTA: date pode ser um Date e não um String? confirmar com grupo / ficheiro TODO
        {
            List<CO> lista = new List<CO>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM CO WHERE date >= @datw AND date <= @date and local = @local";
                cmd.Parameters.AddWithValue("@date", date + "T00:00:00.000");
                cmd.Parameters.AddWithValue("@date", date + "T23:59:59.000");
                cmd.Parameters.AddWithValue("@local", local);

                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CO n = new CO();
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

        [Route("api/{local}/CO")]
        public IEnumerable<CO> GetSensorCity(string local) //NOTA: date pode ser um Date e não um String? confirmar com grupo / ficheiro TODO
        {
            List<CO> lista = new List<CO>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM CO WHERE local = @local";
                cmd.Parameters.AddWithValue("@local", local);

                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CO n = new CO();
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
