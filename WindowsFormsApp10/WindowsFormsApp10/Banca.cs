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
    public partial class Banca : Form
    {
        string[] valori = new string[36];
        public Banca()
        {
            InitializeComponent();
            carica();
            creaConto.Visible = listaConti.Visible = ulist.Visible = prelievo.Visible = ricarica.Visible = false;
            reloader();
        }

        private void login_form_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void reg_form_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void creaConto_Click(object sender, EventArgs e)
        {
            CreaConto c = new CreaConto();
            this.Hide();
            c.Show();
        }

        private void reloader()
        {
            if (Login.UUID != "")
            {
                Data d = new Data();
                login_form.Visible = reg_form.Visible = false;
                creaConto.Visible = listaConti.Visible = true;
                ctable();
                if (Login.UUID == "#B-BZ66G-P3")
                {
                    ulist.Visible = true;
                    utable();
                }
            }
        }
        private void ctable()
        {
            Data d = new Data();
            MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM Conti WHERE ID_Utente = '" + Login.UUID + "'", d.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            d.databaseConnection.Open();
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            listaConti.Columns.Add("1", "Nome Conto");
            listaConti.Columns.Add("1", "IBAN");
            listaConti.Columns.Add("1", "Tipo");
            listaConti.Columns.Add("1", "Saldo");
            listaConti.Columns.Add("1", "Spese");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listaConti.Rows.Add(reader.GetString(4), reader.GetString(3), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                }
            }
        }
        private void utable()
        {
            Data d = new Data();
            MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM Utenti", d.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            d.databaseConnection.Open();
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            ulist.Columns.Add("1", "Codice");
            ulist.Columns.Add("1", "Nome");
            ulist.Columns.Add("1", "Cognome");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ulist.Rows.Add(reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
            }
        }

        private void carica()
        {
            for(int i = 0; i < 36; i++)
            {
                if(i < 10)
                {
                    valori[i] = Convert.ToString(i);
                }
                else
                {
                    valori[i] = Convert.ToString((char)('a' + i - 10));
                }
            }
        }
    }
}
