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
    public partial class CreaConto : Form
    {
        public string[] type = { "Old", "Normal", "Young" };
        public CreaConto()
        {
            InitializeComponent();
            for (int i = 0; i < type.Length; i++)
            {
                comboBox1.Items.Add(type[i]);
            }
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void build_conto_Click(object sender, EventArgs e)
        {
            Data d = new Data();
            GenData gd = new GenData();
            int cp = Convert.ToInt32(d.cdb("SELECT COUNT(*) FROM Conti WHERE Nome_Conto = '" + comboBox1.Text + "'"));
            d.databaseConnection.Close();
            if(cp == 0)
            {
                int spese = 0;
                if(comboBox1.Text == "Young")
                {
                    spese = 12;
                }
                else
                {
                    spese = 24;
                }
                d.db("INSERT INTO Conti(ID_Conto, ID_Utente, IBAN, Nome_Conto, Tipologia, Saldo, Spese) VALUES('" + gd.IDC() + "', '" + Login.UUID + "', '" + gd.IBAN() + "', '" + lbl_nc.Text + "', '" + comboBox1.Text + "', '0', '"+ spese +"')");
                this.Close();
                Banca b = new Banca();
                b.Show();
            }
        }
        private void btn_info_Click(object sender, EventArgs e)
        {
            Tipologie t = new Tipologie();
            this.Hide();
            t.ShowDialog();
            this.Show();
        }
    }
}
