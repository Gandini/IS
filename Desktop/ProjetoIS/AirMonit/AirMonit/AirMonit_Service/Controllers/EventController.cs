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
    public class EventController : ApiController
    {

        private string CONNSTRING = System.Configuration.ConfigurationManager.ConnectionStrings["AirMonit_Service.Properties.Settings.DBConn"].ConnectionString;

        public IHttpActionResult Post([FromBody]Events e)
        {
            SqlConnection conn = new SqlConnection(CONNSTRING);


            try
            {
                if (e != null)
                {
                    string userId = e.userId;
                    string description = e.description;
                    int temp = e.temp;
                    string airQual = e.airQual;
                    int value = e.value;
                    string local = e.local;
                    DateTime date = e.date;
                    

                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO Eventos(userId,description,temp,airQual,value,local,date) VALUES(@userId,@description,@temp,@airQual,@value,@local,@date)";


                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@temp", temp);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@local", local);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@airQual", airQual);
                    cmd.Connection = conn;

                    int nRows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (nRows > 0)
                    {
                        return Ok();
                    }
                    return NotFound();
                }

                return BadRequest();
            }
            catch (Exception)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
                return NotFound();
            }
        }

        [Route("api/Events")]
        public IEnumerable<Events> GetEvents()
        {
            List<Events> lista = new List<Events>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Eventos";
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Events n = new Events();
                    n.value = (int)reader["value"];
                    n.date = (DateTime)reader["date"];
                    n.local = (string)reader["local"];
                    n.description = (string)reader["description"];
                    n.temp = (int)reader["temp"];
                    n.userId = (string)reader["userId"];
                    n.airQual = (string)reader["airQual"];



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
