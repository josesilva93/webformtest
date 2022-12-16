using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PageWeb.Controller
{
    public class ControllerTest
    {
        sqlConnection sqlcon = new sqlConnection();

        public List<Dictionary<string,string>> GetAllCumples()
        {
            List<Dictionary<string, string>> cumples = new List<Dictionary<string, string>>();

            String displayQuery = "SELECT * FROM test";
            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlcon.OpenConnection());
            SqlDataReader dataReader = viewCommand.ExecuteReader();
            while (dataReader.Read())
            {
                int id = dataReader.GetInt32(0);
                int dia = dataReader.GetInt32(1);
                int mes = dataReader.GetInt32(2);
                string nombre = dataReader.GetValue(3).ToString();
                string fecha = dia + "/" + mes;
                Dictionary<string, string> myDictionary = new Dictionary<string, string>();            
                myDictionary.Add(nombre, fecha);
                cumples.Add(myDictionary);
            }
            dataReader.Close();
            sqlcon.CloseConnection();
            return cumples;
        }
    }
}