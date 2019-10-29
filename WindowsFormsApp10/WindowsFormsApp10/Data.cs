using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp10
{
    class Data
    {
        public MySqlConnection databaseConnection = new MySqlConnection("");
        public void db(string query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            databaseConnection.Close();
        }
        public object cdb(string query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            int t = 0;
            while (reader.Read())
            {
                t = Convert.ToInt32(reader.GetString(0));
            }
            return t;
        }
        public object fetch(string query, int var)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDatabase.ExecuteReader();
            reader.Read();
            return reader.GetString(var);
        }
    }
}
