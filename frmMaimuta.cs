using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atesat_v._1._1
{
    public partial class frmMaimuta : Form
    {
        int scor = 0, vieti = 3, tInterval, ratInterval;
        private List<PictureBox> pbList = new List<PictureBox>();

        public frmMaimuta()
        {
            InitializeComponent();

            pbList.Add(pictureBox1);
            pbList.Add(pictureBox2);
            pbList.Add(pictureBox3);
            pbList.Add(pictureBox4);
            pbList.Add(pictureBox5);
            pbList.Add(pictureBox6);
            pbList.Add(pictureBox7);
            pbList.Add(pictureBox8);
            pbList.Add(pictureBox9);
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            pbStart.Visible = false;

            scor = 0;
            vieti = 3;
            tInterval = 800;
            ratInterval = 20;

            lbScor.Visible = true;

            pbLives1.Visible = true;
            pbLives2.Visible = true;
            pbLives3.Visible = true;

            timer1.Enabled = true;
            timer1.Start();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (Utilizator.bani >= 10)
            {
                Utilizator.bani -= 10;
                pbStart.Visible = true;

                for (int i = 0; i < 9; i++)
                {
                    pbList[i].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                    pbList[i].Tag = "u";
                    pbList[i].Visible = true;
                }


                lbMonedeObt.Visible = false;
                lbMonedeTot.Visible = false;

                pbJocNou.Visible = false;
                pbIesire.Visible = false;

                lbScor.Visible = false;
                pbLives1.Visible = false; pbLives2.Visible = false; pbLives3.Visible = false;
            }
            else
                MessageBox.Show("Credit insuficient pentru a rejuca!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 9);

            pbList[num].Image = Atesat_v._1._1.Properties.Resources.monkey_161532_640;
            pbList[num].Tag = "c";
            pbList[num].Cursor = Cursors.Hand;

            timer1.Enabled = false;
            timer2.Enabled = true;
            timer2.Interval = tInterval;
            timer2.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pbList[0].Tag.ToString() == "c")
            {
                scor++;
                lbScor.Text = "Scor: " + Convert.ToString(scor);

                pbList[0].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[0].Tag = "u";
                pbList[0].Cursor = Cursors.Default;

                tInterval = Math.Max(500, tInterval - ratInterval);
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pbList[1].Tag.ToString() == "c")
            {
                scor++;
                lbScor.Text = "Scor: " + Convert.ToString(scor);

                pbList[1].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[1].Tag = "u";
                pbList[1].Cursor = Cursors.Default;

                tInterval = Math.Max(500, tInterval - ratInterval);
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pbList[2].Tag.ToString() == "c")
            {
                scor++;
                lbScor.Text = "Scor: " + Convert.ToString(scor);

                pbList[2].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[2].Tag = "u";
                pbList[2].Cursor = Cursors.Default;

                tInterval = Math.Max(500, tInterval - ratInterval);
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pbList[3].Tag.ToString() == "c")
            {
                scor++;
                lbScor.Text = "Scor: " + Convert.ToString(scor);

                pbList[3].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[3].Tag = "u";
                pbList[3].Cursor = Cursors.Default;

                tInterval = Math.Max(500, tInterval - ratInterval);
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pbList[4].Tag.ToString() == "c")
            {
                scor++;
                lbScor.Text = "Scor: " + Convert.ToString(scor);

                pbList[4].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[4].Tag = "u";
                pbList[4].Cursor = Cursors.Default;

                tInterval = Math.Max(500, tInterval - ratInterval);
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pbList[5].Tag.ToString() == "c")
            {
                scor++;
                lbScor.Text = "Scor: " + Convert.ToString(scor);

                pbList[5].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[5].Tag = "u";
                pbList[5].Cursor = Cursors.Default;

                tInterval = Math.Max(500, tInterval - ratInterval);
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pbList[6].Tag.ToString() == "c")
            {
                scor++;
                lbScor.Text = "Scor: " + Convert.ToString(scor);

                pbList[6].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[6].Tag = "u";
                pbList[6].Cursor = Cursors.Default;

                tInterval = Math.Max(500, tInterval - ratInterval);
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pbList[7].Tag.ToString() == "c")
            {
                scor++;
                lbScor.Text = "Scor: " + Convert.ToString(scor);

                pbList[7].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[7].Tag = "u";
                pbList[7].Cursor = Cursors.Default;

                tInterval = Math.Max(500, tInterval - ratInterval);
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pbList[8].Tag.ToString() == "c")
            {
                scor++;
                lbScor.Text = "Scor: " + Convert.ToString(scor);

                pbList[8].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[8].Tag = "u";
                pbList[8].Cursor = Cursors.Default;

                tInterval = Math.Max(500, tInterval - ratInterval);
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            --vieti;

            timer2.Enabled = false;
            tInterval = 900;

            if (vieti == 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    pbList[i].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                    pbList[i].Tag = "u";
                    pbList[i].Cursor = Cursors.Default;
                }

                pbLives1.Visible = false;
                lbScor.Text = "Scor: 0";
                lbScor.Visible = false;

                Utilizator.bani += scor;

                timer2.Enabled = false;

                for (int i = 0; i < 9; i++)
                    pbList[i].Visible = false;

                lbMonedeObt.Text = "Ati pierdut, obtinand: " + Convert.ToString(scor) + " monede";
                lbMonedeObt.Visible = true;
                lbMonedeTot.Text = "Noul numar de monede: " + Convert.ToString(Utilizator.bani);
                lbMonedeTot.Visible = true;

                pbJocNou.Visible = true;
                pbIesire.Visible = true;
            }
            else
            {
                if (vieti == 2)
                    pbLives3.Visible = false;
                else
                    pbLives2.Visible = false;

                for (int i = 0; i < 9; i++)
                {
                    if (pbList[i].Tag.ToString() == "c")
                    {
                        pbList[i].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md___Copy;
                        pbList[i].Tag = "u";
                        pbList[i].Cursor = Cursors.Default;

                        timer3.Enabled = true;
                        timer3.Start();

                        break;
                    }
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                pbList[i].Image = Atesat_v._1._1.Properties.Resources.light_blue_circle_md;
                pbList[i].Tag = "u";
                pbList[i].Cursor = Cursors.Default;
            }

            timer3.Enabled = false;

            timer1.Enabled = true;
            timer1.Start();
        }
    }
}
