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
    public partial class Login : Form
    {
        public static string UUID = ""; //#B-BZ66G-P3
        Banca banca;
        public Login()
        {
            InitializeComponent();
        }
        public Login(Banca b)
        {
            banca = b;
        }
        private void login_send_Click_1(object sender, EventArgs e)
        {
            Data d = new Data();
            HashPSW h = new HashPSW();
            if(lbl_user.Text != "")
            {
                if(lbl_password.Text != "")
                {
                    int cp = Convert.ToInt32(d.cdb("SELECT COUNT(*) FROM Utenti WHERE ID_Utente = '" + lbl_user.Text + "' AND Password = '" + h.Hashing(lbl_password.Text) + "'"));
                    if (cp == 1)
                    {
                        UUID = lbl_user.Text;
                        MessageBox.Show("Login avvenuto correttamente", "Informazioni", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Banca b = new Banca();
                        this.Hide();
                        b.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password o Utente errato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password Non inserita", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Codice Utente Non inserito", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
