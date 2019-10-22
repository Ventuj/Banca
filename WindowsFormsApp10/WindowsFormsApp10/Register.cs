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
                        d.db("INSERT INTO Utenti(ID_Utente, Nome, Cognome, Password) VALUES('" + uuid + "', '" + lbl_user.Text + "', '" + lbl_cogn.Text + "', '" + h.Hashing(lbl_password.Text) + "')");
                        lbl_cogn.Visible = lbl_user.Visible = lbl_password.Visible = label1.Visible = label2.Visible = label3.Visible = register_send.Visible = false;
                        Login.UUID = uuid;
                        MessageBox.Show("Registrazione Completata");
                        this.Close();
                        Banca b = new Banca();
                        b.Show();
                    }
                }
            }
        }

        private void Closer_Click(object sender, EventArgs e)
        {
            this.Close();
            Banca b = new Banca();
            b.Show();
        }
    }
}
