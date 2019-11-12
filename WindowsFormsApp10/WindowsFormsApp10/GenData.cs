using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    class GenData
    {
        public string[] valori = new string[36];
        public GenData()
        {
            for (int i = 0; i < 36; i++)
            {
                if (i < 10)
                {
                    valori[i] = Convert.ToString(i);
                }
                else
                {
                    valori[i] = Convert.ToString((char)('a' + i - 10));
                }
            }
        }
        public string UUID()
        {
            string cu = "#";
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                if (cu.Length == 2 || cu.Length == 8)
                {
                    cu += "-";
                }
                else
                {
                    cu += valori[rnd.Next(0, 36)];
                }
            }
            return cu.ToUpper();
        }
        public string IBAN()
        {
            string iban = "IT";
            Random rnd = new Random();
            iban += Convert.ToString(rnd.Next(0, 9)) + Convert.ToString(rnd.Next(0, 9));
            iban += Convert.ToString((char)('a' + rnd.Next(0, 26)));
            for (int i = 0; i < 22; i++)
            {
                iban += Convert.ToString(rnd.Next(0, 9));
            }
            return iban.ToUpper();
        }
        public string IDC()
        {
            string cc = "#";
            Random rnd = new Random();
            for (int i = 0; i < 19; i++)
            {
                if (cc.Length == 3 || cc.Length == 9)
                {
                    cc += "-";
                }
                else
                {
                    cc += valori[rnd.Next(0, 36)];
                }
            }
            return cc.ToUpper();
        }
        public string IDT()
        {
            string idt = "@";
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                if (idt.Length == 4 || idt.Length == 10)
                {
                    idt += "-";
                }
                else
                {
                    idt += valori[rnd.Next(0, 36)];
                }
            }
            return idt.ToUpper();
        }
        public long converter(string str)
        {
            string[] st = str.Split('/');
            DateTime d = new DateTime(Convert.ToInt32(st[2]), Convert.ToInt32(st[1]), Convert.ToInt32(st[0]), 0, 0, 0);
            long epoch = (d.Ticks - 621355968000000000) / 10000000;
            return epoch;
        }
    }
}
