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
    public class StatisticsController : ApiController
    {
        private string CONNSTRING = System.Configuration.ConfigurationManager.ConnectionStrings["AirMonit_Service.Properties.Settings.DBConn"].ConnectionString;

        [Route("api/O3/date/{date}/local/{local}")]
        public IEnumerable<Statistics> GetO3(string date, string local)
        {
            List<Statistics> lista = new List<Statistics>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                if (local != null)
                {
                    
                    cmd.CommandText = "SELECT min(value) as min, max(value) as max, avg(value) as avg FROM O3 where convert(varchar(10), date, 121) = convert(varchar(10), @date, 105) and local = @local ";
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@local", local);
                   
                }

                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Statistics n = new Statistics();
                    n.min = (int)reader["min"];
                    n.max = (int)reader["max"];
                    n.avg = (int)reader["avg"];
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

        [Route("api/NO/date/{date}/local/{local}")]
        public IEnumerable<Statistics> GetNO(string date, string local)
        {
            List<Statistics> lista = new List<Statistics>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                if (local != null)
                {

                    cmd.CommandText = "SELECT min(value) as min, max(value) as max, avg(value) as avg FROM NO where convert(varchar(10), date, 121) = convert(varchar(10), @date, 105) and local = @local ";
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@local", local);

                }

                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Statistics n = new Statistics();
                    n.min = (int)reader["min"];
                    n.max = (int)reader["max"];
                    n.avg = (int)reader["avg"];
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

        [Route("api/CO/date/{date}/local/{local}")]
        public IEnumerable<Statistics> GetCO(string date, string local)
        {
            List<Statistics> lista = new List<Statistics>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                if (local != null)
                {

                    cmd.CommandText = "SELECT min(value) as min, max(value) as max, avg(value) as avg FROM CO where convert(varchar(10), date, 121) = convert(varchar(10), @date, 105) and local = @local ";
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@local", local);

                }

                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Statistics n = new Statistics();
                    n.min = (int)reader["min"];
                    n.max = (int)reader["max"];
                    n.avg = (int)reader["avg"];
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
