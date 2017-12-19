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

        public IHttpActionResult Post([FromBody]Event e)
        {
            SqlConnection conn = new SqlConnection(CONNSTRING);


            try
            {
                if (e != null)
                {
                    string userId = e.userId;
                    string event_description = e.event_description;
                    int temperature = e.temperature;
                    string air_quality = e.air_quality;
                    int value = e.value;
                    string City_name = e.City_name;
                    DateTime date = e.date;
                    

                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO Event(userId,event_description,temperature,air_quality,value,City_name,date) VALUES(@userId,@event_description,@temperature,@air_quality,@value,@City_name,@date)";


                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@event_description", event_description);
                    cmd.Parameters.AddWithValue("@temperature", temperature);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@City_name", City_name);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@air_quality", air_quality);
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

        [Route("api/Event")]
        public IEnumerable<Event> GetEvent()
        {
            List<Event> lista = new List<Event>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Event";
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Event n = new Event();
                    n.value = (int)reader["value"];
                    n.date = (DateTime)reader["date"];
                    n.City_name = (string)reader["City_name"];
                    n.event_description = (string)reader["event_description"];
                    n.temperature = (int)reader["temperature"];
                    n.userId = (string)reader["userId"];
                    n.air_quality = (string)reader["air_quality"];



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
