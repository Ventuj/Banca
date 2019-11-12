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
    public partial class Tipologie : Form
    {
        public Tipologie()
        {
            InitializeComponent();
        }

        private void Closer_Click(object sender, EventArgs e)
        {
            CreaConto c = new CreaConto();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }
    }
}
