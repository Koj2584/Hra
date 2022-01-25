using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hra
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int min = int.Parse(textBox1.Text);
                int max = int.Parse(textBox2.Text);
                bool prvocislo;

                while (min <= max)
                {
                    prvocislo = (min == 2 || min % 2 != 0) && min != 1;
                    for (int i = 3;i<=Math.Sqrt(min)&&prvocislo;i+=2)
                    {
                        prvocislo = min % i != 0;
                    }
                    if(prvocislo)
                    {
                        listBox1.Items.Add("Číslo " + min + " je prvocislo");
                    }
                    else
                    {
                        //listBox1.Items.Add("Číslo " + min + " není prvocislo");
                    }
                    min++;
                }
            }
            catch
            {
                MessageBox.Show("Chibaaaa!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
