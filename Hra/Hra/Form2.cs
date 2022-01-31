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
            vymaz();
        }

        public void vymaz()
        {
            foreach (object o in this.Controls)
            {
                if (o is CheckBox)
                    ((CheckBox)o).Checked = false;
                if (o is TextBox)
                    (o as TextBox).Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int cislo = int.Parse(textBox1.Text);
                int whSoucet = 0, foreSoucet = 0, dwhSoucet = 0;
                if(cislo>0)
                {
                    while(cislo > 0)
                    {
                        int cifra = cislo % 10;
                        cislo /= 10;
                        whSoucet += cifra;
                    }

                    foreach(char x in textBox1.Text)
                    {
                        int i = int.Parse(x.ToString());
                        foreSoucet += i;
                    }

                    cislo = int.Parse(textBox1.Text);
                    do
                    {
                        int cifra = cislo % 10;
                        cislo /= 10;
                        dwhSoucet += cifra;
                    } while (cislo > 0);

                    label1.Text = "Cyklus while " + whSoucet;
                    label2.Text = "Cyklus foreach " + foreSoucet;
                    label3.Text = "Cyklus do while " + dwhSoucet;
                }
            }
            catch
            {
                MessageBox.Show("Chybaaaa!!");
            }
        }
    }
}
