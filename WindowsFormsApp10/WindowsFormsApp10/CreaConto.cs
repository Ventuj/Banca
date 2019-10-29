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

        private void Closer_Click(object sender, EventArgs e)
        {
            this.Close();
            Banca b = new Banca();
            b.Show();
        }

        private void build_conto_Click(object sender, EventArgs e)
        {
            Data d = new Data();
            GenData gd = new GenData();
            d.db("INSERT INTO Conti(ID_Conto, ID_Utente, IBAN, Nome_Conto, Tipologia, Saldo) VALUES('"+ gd.IDC() +"', '"+ Login.UUID +"', '" + gd.IBAN() + "', '" + lbl_nc.Text + "', '"+ comboBox1.Text +"', '0')");
            this.Close();
            Banca b = new Banca();
            b.Show();
        }
    }
}
