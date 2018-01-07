﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsLogin
{
    class ConnectMDB
    {
        private string Query { get; set; }

        public ConnectMDB(string query)
        {
            this.Query = query;
        }

        public DataTable ConnectDB()
        {
            DataTable myDataTable = new DataTable();

            try
            {
                // Open OleDb Connection
                OleDbConnection myConnection = new OleDbConnection
                {
                    ConnectionString = DBpath()
                };

                myConnection.Open();

                // Execute Queries
                OleDbCommand cmd = myConnection.CreateCommand();
                cmd.CommandText = $"{this.Query}";
                
                // close conn after complete
                OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection); 

                // Load the result into a DataTable
                myDataTable.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Няма връзка с базата: " + ex.Message);
                myDataTable = null;
            }

            return myDataTable;
        }

        private string DBpath()
        {
            string myConnectionString =
               @"Provider=Microsoft.Jet.OLEDB.4.0;" +
               "Data Source=" +
               "C:\\Safesmart Security Platform\\database\\Property2.mdb;" +
               "Persist Security Info=True;" +
               "Jet OLEDB:Database Password=AnsonSTMake811;";

            return myConnectionString;
        }
    }
}
