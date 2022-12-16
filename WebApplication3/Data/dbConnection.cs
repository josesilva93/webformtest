using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace PageWeb
{
    public class sqlConnection
    {
        private SqlConnection con = new SqlConnection("Server=DESKTOP-B2SJJGE\\SQLEXPRESS;DataBase= test2;Integrated Security=true");
        public SqlConnection OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public SqlConnection CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            return con;
        }
    }
}