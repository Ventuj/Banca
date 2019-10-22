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
    public partial class Form1 : Form
    {
        int c1, c2, c3 = 0;
        string[] valori = new string[36];
        public Form1()
        {
            InitializeComponent();
            carica();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string cc = "#";
            Random rnd = new Random();
            for(int i = 0; i < 19; i++)
            {
                if(cc.Length == 3 || cc.Length == 9)
                {
                    cc += "-";
                }
                else
                {
                    cc += valori[rnd.Next(0, 36)];
                }
               
            }
            label1.Text = cc.ToUpper();
            c1++;
            button1.Text = "CC - " + Convert.ToString(c1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cu = "#";
            Random rnd = new Random();
            for (int i = 0; i < 14; i++)
            {
                if (cu.Length == 4 || cu.Length == 10)
                {
                    cu += "-";
                }
                else
                {
                    cu += valori[rnd.Next(0, 36)];
                }

            }
            label2.Text = cu.ToUpper();
            c2++;
            button2.Text = "CU - " + Convert.ToString(c2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string iban = "IT";
            Random rnd = new Random();
            iban += Convert.ToString(rnd.Next(0, 9)) + Convert.ToString(rnd.Next(0, 9));
            iban += Convert.ToString((char)('a' + rnd.Next(0, 26)));
            for(int i = 0; i < 22; i++)
            {
                iban += Convert.ToString(rnd.Next(0, 9));
            }
            label3.Text = iban.ToUpper();
            c3++;
            button3.Text = "IBAN - " + Convert.ToString(c3);
        }
    }
}
