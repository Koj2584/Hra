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
    public partial class Form1 : Form
    {
        int pozice = 1;
        int cas = 5;
        bool gameOver = false;
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new Random();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gameOver)
            {
                if (e.KeyCode == Keys.D)
                {
                    if (pozice != 3 && pozice != 6 && pozice != 9)
                        pozice++;
                }
                if (e.KeyCode == Keys.A)
                {
                    if (pozice != 1 && pozice != 4 && pozice != 7)
                        pozice--;
                }
                if (e.KeyCode == Keys.S)
                {
                    if (pozice < 7)
                        pozice += 3;
                }
                if (e.KeyCode == Keys.W)
                {
                    if (pozice > 3)
                        pozice -= 3;
                }

                switch (pozice)
                {
                    case 1:
                        panel1.Controls.Add(this.Hrac);
                        Hrac.Location = new Point(60, 60);
                        break;
                    case 2:
                        panel2.Controls.Add(this.Hrac);
                        Hrac.Location = new Point(60, 60);
                        break;
                    case 3:
                        panel3.Controls.Add(this.Hrac);
                        Hrac.Location = new Point(60, 60);
                        break;
                    case 4:
                        panel4.Controls.Add(this.Hrac);
                        Hrac.Location = new Point(60, 60);
                        break;
                    case 5:
                        panel5.Controls.Add(this.Hrac);
                        Hrac.Location = new Point(60, 60);
                        break;
                    case 6:
                        panel6.Controls.Add(this.Hrac);
                        Hrac.Location = new Point(60, 60);
                        break;
                    case 7:
                        panel7.Controls.Add(this.Hrac);
                        Hrac.Location = new Point(60, 60);
                        break;
                    case 8:
                        panel8.Controls.Add(this.Hrac);
                        Hrac.Location = new Point(60, 60);
                        break;
                    case 9:
                        panel9.Controls.Add(this.Hrac);
                        Hrac.Location = new Point(60, 60);
                        break;
                }
                this.Text = "Pozice " + pozice;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cas < 0)
            {
                timer1.Stop();
                cas = 5;
                losovani();
            }
            else
            {
                label1.Text = "Losování za " + cas;
                cas--;
            }
        }

        public void losovani()
        {
            int rndm = rng.Next(1, 10);
            switch (rndm)
            {
                case 1:
                    panel1.BackColor = Color.DimGray;
                    break;
                case 2:
                    panel2.BackColor = Color.DimGray;
                    break;
                case 3:
                    panel3.BackColor = Color.DimGray;
                    break;
                case 4:
                    panel4.BackColor = Color.DimGray;
                    break;
                case 5:
                    panel5.BackColor = Color.DimGray;
                    break;
                case 6:
                    panel6.BackColor = Color.DimGray;
                    break;
                case 7:
                    panel7.BackColor = Color.DimGray;
                    break;
                case 8:
                    panel8.BackColor = Color.DimGray;
                    break;
                case 9:
                    panel9.BackColor = Color.DimGray;
                    break;
            }
            if(rndm == pozice)
            {
                label1.Text = "Game over";
                gameOver = true;
            }
            else
            {

            }
        }
    }
}
