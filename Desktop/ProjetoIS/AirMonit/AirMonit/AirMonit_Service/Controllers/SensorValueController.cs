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
    public class SensorValueController : ApiController
    {
        private string CONNSTRING = System.Configuration.ConfigurationManager.ConnectionStrings["AirMonit_Service.Properties.Settings.ConnString"].ConnectionString;

        //TODO
        [Route("api/{city}/sensors/{date}")]
        public IEnumerable<SensorValue> GetSensorCityDate(string city, string date) //NOTA: date pode ser um Date e não um String? confirmar com grupo / ficheiro TODO
        {
            //TODO
            return null;
        }



        [Route("api/{city}/sensors")]
        public IEnumerable<SensorValue> GetSensorCity(string city)
        {
            List<SensorValue> lista = new List<SensorValue>();
            SqlConnection conn = new SqlConnection(CONNSTRING);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();

                if (city != null)
                {
                    if (city == "All")
                    {
                        // cmd.CommandText = "SELECT * FROM CO, NO2, O3 order by date";
                        cmd.CommandText = "SELECT * FROM CO order by date"; //codigo mais simples E INCOMPLETO só para testar
                    }
                    else
                    {
                        //cmd.CommandText = "SELECT * FROM CO, NO2, O3 where local = @local order by date";
                        cmd.CommandText = "SELECT * FROM CO WHERE @local = local order by date "; //codigo mais simples E INCOMPLETO só para testar
                        cmd.Parameters.AddWithValue("@local", city);
                    }

                }

                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SensorValue sv = new SensorValue();
                    sv.value = (int)reader["value"];
                    sv.date = (DateTime)reader["date"];
                    sv.local = (string)reader["local"];


                    lista.Add(sv);
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

    

    [Route("api/cities")]
    public IEnumerable<String> GetCities()
    {
        List<String> lista = new List<String>();
        SqlConnection conn = new SqlConnection(CONNSTRING);

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT local FROM CO UNION SELECT local FROM NO2 UNION SELECT local FROM O3;";

            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(Convert.ToString(reader.Read()));
                   
            }

            lista.Add("asd");                    
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
