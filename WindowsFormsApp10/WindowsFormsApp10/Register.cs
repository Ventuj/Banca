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
    public partial class Register : Form
    {
        string[] valori = new string[36];
        public Register()
        {
            InitializeComponent();
        }

        private void register_send_Click(object sender, EventArgs e)
        {
            Data d = new Data();
            HashPSW h = new HashPSW();
            GenData gd = new GenData();
            if(lbl_user.Text != "")
            {
                if(lbl_cogn.Text != "")
                {
                    if(lbl_password.Text != "")
                    {
                        string uuid = gd.UUID();
                        d.db("INSERT INTO Utenti(ID_Utente, Nome, Cognome, Password, NData) VALUES('" + uuid + "', '" + lbl_user.Text + "', '" + lbl_cogn.Text + "', '" + h.Hashing(lbl_password.Text) + "', '"+ NData.Text +"')");
                        lbl_cogn.Visible = lbl_password.Visible = label1.Visible = label2.Visible = label3.Visible = register_send.Visible = label5.Visible = NData.Visible = false;
                        Login.UUID = uuid;
                        MessageBox.Show("Registrazione Completata", "Informazioni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbl_user.Text = uuid;
                    }
                    else
                    {
                        MessageBox.Show("Password Non inserita", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Cognome non inserito", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nome non inserito", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
