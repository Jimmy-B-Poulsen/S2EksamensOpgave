using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Documents;
using EksamensProject.Classes;

namespace EksamensProject.Classes
{
    public class DBConnection
    {
        string connectionString = "Data Source=CV-BB-5989;Initial Catalog = EksamensOpgave; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Execute function that sends a query to the database, and runs it.
        //since Execute is private, i can only call it within the class DBConnection
        private DataSet Execute(String query)
        {
            DataSet resultset = new DataSet();
            using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(connectionString))))
            {
                adapter.Fill(resultset);
            }
            return resultset;
        }

        //method to call the execute function since it's private
        public void Temp(string query)
        {
            Execute(query);
        }

        public DataTable TableReturner(string query)
        {
            DataTable temptable = new DataTable();
            temptable = Execute(query).Tables["players"];
            return temptable;
        }
    }
}


