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
                    //cmd.CommandText = "SELECT min(value) as min, max(value) as max, avg(value) as avg FROM O3 where convert(varchar(10), date, 121) = convert(varchar(10), @date, 121) and local = @local ";
                    cmd.CommandText = "select date = dateadd(hh, datepart(hh, date), cast(CAST(date as date) as datetime)), min(value) as min, max(value) as max, avg(value) as avg " +
                                         "from O3 " +
                                         "WHERE convert(varchar(10), date, 121) >= convert(varchar(10), @date, 121) AND convert(varchar(10), date, 121) <= convert(varchar(10), @dateEnd, 121) and local = @local " +
                                         "group by dateadd(hh, datepart(hh, date), cast(CAST(date as date) as datetime))";
                    string[] tempsplit = date.Split('-');
                    string joinstring = "-";
                    string newdate = tempsplit[2] + joinstring + tempsplit[1] + joinstring + tempsplit[0];
                    cmd.Parameters.AddWithValue("@date", newdate + "T00:00:00.000");
                    cmd.Parameters.AddWithValue("@dateEnd", newdate + "T23:59:59.000");
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
                    //n.local = (string)reader["local"];


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

        [Route("api/NO2/date/{date}/local/{local}")]
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
                    cmd.CommandText = "select date = dateadd(hh, datepart(hh, date), cast(CAST(date as date) as datetime)), min(value) as min, max(value) as max, avg(value) as avg " +
                                                             "from NO2 " +
                                                             "WHERE convert(varchar(10), date, 121) >= convert(varchar(10), @date, 121) AND convert(varchar(10), date, 121) <= convert(varchar(10), @dateEnd, 121) and local = @local " +
                                                             "group by dateadd(hh, datepart(hh, date), cast(CAST(date as date) as datetime))";
                    string[] tempsplit = date.Split('-');
                    string joinstring = "-";
                    string newdate = tempsplit[2] + joinstring + tempsplit[1] + joinstring + tempsplit[0];
                    cmd.Parameters.AddWithValue("@date", newdate + "T00:00:00.000");
                    cmd.Parameters.AddWithValue("@dateEnd", newdate + "T23:59:59.000");
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
                    //n.local = (string)reader["local"];


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
                    cmd.CommandText = "select date = dateadd(hh, datepart(hh, date), cast(CAST(date as date) as datetime)), min(value) as min, max(value) as max, avg(value) as avg " +
                                                             "from CO " +
                                                             "WHERE convert(varchar(10), date, 121) >= convert(varchar(10), @date, 121) AND convert(varchar(10), date, 121) <= convert(varchar(10), @dateEnd, 121) and local = @local " +
                                                             "group by dateadd(hh, datepart(hh, date), cast(CAST(date as date) as datetime))";
                    string[] tempsplit = date.Split('-');
                    string joinstring = "-";
                    string newdate = tempsplit[2] + joinstring + tempsplit[1] + joinstring + tempsplit[0];
                    cmd.Parameters.AddWithValue("@date", newdate + "T00:00:00.000");
                    cmd.Parameters.AddWithValue("@dateEnd", newdate + "T23:59:59.000");
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
                    //n.local = (string)reader["local"];


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
