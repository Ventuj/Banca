using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class ViewConto : Form
    {
        string id;
        public ViewConto(string i)
        {
            InitializeComponent();
            ctrans(i);
            id = i;
            Data d = new Data();
            lbl_nome.Text = "Conto -" + Convert.ToString(d.fetch("SELECT * FROM Conti WHERE ID_Conto = '" + id + "'", 4));
        }

        private void ctrans(string i)
        {
            Data d = new Data();
            MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM `Transazioni` WHERE ID_Conto='" + i + "'", d.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            d.databaseConnection.Open();
            MySqlDataReader r = commandDatabase.ExecuteReader();
            transazioni_table.Columns.Add("1", "Ammontare");
            transazioni_table.Columns.Add("1", "Causale");
            transazioni_table.Columns.Add("1", "Data");
            transazioni_table.Columns.Add("1", "Orario");
            int counter = 0;
            if (r.HasRows)
            {
                while (r.Read())
                {
                    string data = r.GetString(5) + "/" + r.GetString(6) + "/" + r.GetString(7);
                    if (r.GetString(9) == "1")
                    {
                        transazioni_table.Rows.Add(r.GetString(3), r.GetString(4), data, r.GetString(8));
                        transazioni_table.Rows[counter].DefaultCellStyle.BackColor = Color.Red;
                        counter++;
                    }
                    else
                    {
                        transazioni_table.Rows.Add(r.GetString(3), r.GetString(4), data, r.GetString(8));
                        transazioni_table.Rows[counter].DefaultCellStyle.BackColor = Color.Green;
                        counter++;
                    }
                    transazioni_table.ForeColor = Color.White;
                }
            }
            //d.databaseConnection.Close();
        }
        private void Closer_Click(object sender, EventArgs e)
        {
            this.Close();
            Banca b = new Banca();
            b.Show();
        }

        private void ricarica_Click(object sender, EventArgs e)
        {
            Transazione t = new Transazione(id);
            this.Close();
            t.Show();
        }
    }
}
