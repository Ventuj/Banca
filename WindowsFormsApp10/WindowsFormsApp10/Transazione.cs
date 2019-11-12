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
    public partial class Transazione : Form
    {
        string id;
        public Transazione(string i)
        {
            InitializeComponent();
            id = i;
        }

        private void value_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void Closer_Click_1(object sender, EventArgs e)
        {
            this.Close();
            ViewConto v = new ViewConto(id);
            v.Show();
        }

        private void execute_transaction_Click(object sender, EventArgs e)
        {
            Data d = new Data();
            GenData gd = new GenData();
            int Type = 0;
            if(tipo.Text != "")
            {
                if(tipo.Text == "Prelievo")
                {
                    Type = 1;
                }
                else
                {
                    Type = 0;
                }
            }
            string data = Convert.ToString(gd.converter(DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString()));
            string ora;
            if (DateTime.Now.Hour.ToString().Length < 2)
            {
                ora = "0" + DateTime.Now.Hour.ToString();
            }
            else
            {
                ora = DateTime.Now.Hour.ToString();
            }
            if(DateTime.Now.Minute.ToString().Length < 2)
            {
                ora += ":0" + DateTime.Now.Minute.ToString();
            }
            else
            {
                ora += ":" + DateTime.Now.Minute.ToString();
            }
            if (Type == 1)
            {
                double conto = Convert.ToDouble(d.fetch("SELECT * FROM Conti WHERE ID_Conto = '" + id + "'", 6));
                d.databaseConnection.Close();
                double ponte = conto - (Convert.ToDouble(value_text.Text) + d.getContoCom(id));
                d.db("UPDATE Conti SET Saldo = '" + ponte  + "' WHERE ID_Conto = '"+ id + "'");
                d.db("INSERT INTO Transazioni(ID_Conto, ID_Transazione, Ammontare, Causale, Data, Ora, Type) VALUES('" + id + "', '" + gd.IDT() + "', '" + (Convert.ToInt32(value_text.Text) + d.getContoCom(id)) + "', '" + causale_txt.Text + "', '" + data + "', '" + ora + "', '" + Type + "')");
            }
            else
            {
                double conto = Convert.ToDouble(d.fetch("SELECT * FROM Conti WHERE ID_Conto = '" + id + "'", 6));
                d.databaseConnection.Close();
                double ponte = conto + (Convert.ToDouble(value_text.Text) - d.getContoCom(id));
                d.db("UPDATE Conti SET Saldo = '" + ponte + "' WHERE ID_Conto = '" + id + "'");
                d.db("INSERT INTO Transazioni(ID_Conto, ID_Transazione, Ammontare, Causale, Data, Ora, Type) VALUES('" + id + "', '" + gd.IDT() + "', '" + (Convert.ToInt32(value_text.Text) - d.getContoCom(id)) + "', '" + causale_txt.Text + "', '" + data + "', '" + ora + "', '" + Type + "')");
            }
            MessageBox.Show("Transazione Completata con successo");
            this.Close();
            ViewConto v = new ViewConto(id);
            v.Show();
        }
    }
}
