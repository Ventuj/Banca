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
            id = i;
            Data d = new Data();
            transazioni_table.Columns.Add("1", "Ammontare");
            transazioni_table.Columns.Add("1", "Causale");
            transazioni_table.Columns.Add("1", "Data");
            transazioni_table.Columns.Add("1", "Orario");
            transazioni_table.ForeColor = Color.White;
            lbl_nome.Text = "Conto - " + Convert.ToString(d.fetch("SELECT * FROM Conti WHERE ID_Conto = '" + id + "'", 4));
        }

        private void ricarica_Click(object sender, EventArgs e)
        {
            Transazione t = new Transazione(id);
            this.Hide();
            t.ShowDialog();
            this.Show();
        }

        private string conv(string timestamp)
        {
            long time = long.Parse(timestamp);
            System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(time);
            return dateTime.Day.ToString() + "/" + dateTime.Month.ToString() + "/" + dateTime.Year.ToString();
        }
        private void entrate_Click(object sender, EventArgs e)
        {
            transazioni_table.Rows.Clear();
            Data d = new Data();
            MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM `Transazioni` WHERE ID_Conto='" + id + "' AND Type = '0'", d.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            d.databaseConnection.Open();
            MySqlDataReader r = commandDatabase.ExecuteReader();
            int counter = 0;
            if (r.HasRows)
            {
                while (r.Read())
                {
                    transazioni_table.Rows.Add(r.GetString(3), r.GetString(4), conv(r.GetString(5)), r.GetString(6));
                    transazioni_table.Rows[counter].DefaultCellStyle.BackColor = Color.Green;
                    counter++;
                }
            }
            transazioni_table.RowCount = counter;
        }

        private void uscite_Click(object sender, EventArgs e)
        {
            transazioni_table.Rows.Clear();
            Data d = new Data();
            MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM `Transazioni` WHERE ID_Conto='" + id + "' AND Type = '1'", d.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            d.databaseConnection.Open();
            MySqlDataReader r = commandDatabase.ExecuteReader();
            int counter = 0;
            if (r.HasRows)
            {
                while (r.Read())
                {
                    transazioni_table.Rows.Add(r.GetString(3), r.GetString(4), conv(r.GetString(5)), r.GetString(6));
                    transazioni_table.Rows[counter].DefaultCellStyle.BackColor = Color.Red;
                    counter++;
                }
            }
            transazioni_table.RowCount = counter;
        }
        private void tutto_Click(object sender, EventArgs e)
        {
            transazioni_table.Rows.Clear();
            Data d = new Data();
            MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM `Transazioni` WHERE ID_Conto='" + id + "'", d.databaseConnection);
            commandDatabase.CommandTimeout = 60;
            d.databaseConnection.Open();
            MySqlDataReader r = commandDatabase.ExecuteReader();
            int counter = 0;
            if (r.HasRows)
            {
                while (r.Read())
                {
                    if (r.GetString(7) == "1")
                    {
                        transazioni_table.Rows.Add(r.GetString(3), r.GetString(4), conv(r.GetString(5)), r.GetString(6));
                        transazioni_table.Rows[counter].DefaultCellStyle.BackColor = Color.Red;
                        counter++;
                    }
                    else
                    {
                        transazioni_table.Rows.Add(r.GetString(3), r.GetString(4), conv(r.GetString(5)), r.GetString(6));
                        transazioni_table.Rows[counter].DefaultCellStyle.BackColor = Color.Green;
                        counter++;
                    }
                }
            }
            transazioni_table.RowCount = counter;
        }

        private void filtro_Click(object sender, EventArgs e)
        {
            GenData gd = new GenData();
            if (gd.converter(data1.Text) <= gd.converter(data2.Text))
            {
                transazioni_table.Rows.Clear();
                Data d = new Data();
                MySqlCommand commandDatabase = new MySqlCommand("SELECT * FROM `Transazioni` WHERE ID_Conto='" + id + "' AND Data >= '" + gd.converter(data1.Text) + "' AND Data  <= " + gd.converter(data2.Text) + "", d.databaseConnection);
                commandDatabase.CommandTimeout = 60;
                d.databaseConnection.Open();
                MySqlDataReader r = commandDatabase.ExecuteReader();
                int counter = 0;
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        if (r.GetString(7) == "1")
                        {
                            transazioni_table.Rows.Add(r.GetString(3), r.GetString(4), conv(r.GetString(5)), r.GetString(6));
                            transazioni_table.Rows[counter].DefaultCellStyle.BackColor = Color.Red;
                            counter++;
                        }
                        else
                        {
                            transazioni_table.Rows.Add(r.GetString(3), r.GetString(4), conv(r.GetString(5)), r.GetString(6));
                            transazioni_table.Rows[counter].DefaultCellStyle.BackColor = Color.Green;
                            counter++;
                        }
                    }
                }
                transazioni_table.RowCount = counter;
            }
            else
            {
                MessageBox.Show("La prima data deve essere minore o uguale della seconda", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
