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
                    string Uncommon_event_description = e.Uncommon_event_description;
                    int Temperature_in_celcius_degrees = e.Temperature_in_celcius_degrees;
                    string airQual = e.airQual;
                    int value = e.value;
                    string City_name = e.City_name;
                    DateTime date = e.date;
                    

                    conn.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO Event(userId,Uncommon_event_description,Temperature_in_celcius_degrees,airQual,value,City_name,date) VALUES(@userId,@Uncommon_event_description,@Temperature_in_celcius_degrees,@airQual,@value,@City_name,@date)";


                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@Uncommon_event_description", Uncommon_event_description);
                    cmd.Parameters.AddWithValue("@Temperature_in_celcius_degrees", Temperature_in_celcius_degrees);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@City_name", City_name);
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
                    n.Uncommon_event_description = (string)reader["Uncommon_event_description"];
                    n.Temperature_in_celcius_degrees = (int)reader["Temperature_in_celcius_degrees"];
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
