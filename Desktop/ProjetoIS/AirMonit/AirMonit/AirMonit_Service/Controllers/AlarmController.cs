﻿using AirMonit_Service.Models;
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
        private string CONNSTRING = System.Configuration.ConfigurationManager.ConnectionStrings["AirMonit_Service.Properties.Settings.DBConn"].ConnectionString;

      

        [Route("api/{local}/alarms")]
        public IEnumerable<Alarm> Get(string local)
        {
            List<Alarm> lista = new List<Alarm>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();

             if (local == "All") { 
                 cmd.CommandText = "SELECT * FROM Alarm";
            }else{
                    cmd.CommandText = "SELECT * FROM Alarm where local=@local";
                    cmd.Parameters.AddWithValue("@local", local);
                }
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

        [Route("api/{local}/alarms/{startDate}/{endDate}")]
        public IEnumerable<Alarm> GetBetween(string startDate, string endDate, string local)
        {
            List<Alarm> lista = new List<Alarm>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                if (local == "All") {

                    cmd.CommandText = "SELECT * FROM Alarm WHERE startDate >= @startDate AND endDate <= @endDate";
                    cmd.Parameters.AddWithValue("@startDate", startDate + "T00:00:00.000");
                    cmd.Parameters.AddWithValue("@endDate", endDate + "T23:59:59.000");
                    
                }
                else
                {
                    cmd.CommandText = "SELECT * FROM Alarm WHERE startDate >= @startDate AND endDate <= @endDate and local = @local";
                    cmd.Parameters.AddWithValue("@startDate", startDate + "T00:00:00.000");
                    cmd.Parameters.AddWithValue("@endDate", endDate + "T23:59:59.000");
                    cmd.Parameters.AddWithValue("@local", local);
                }
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
