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
    public partial class frmRata : Form
    {
        private List<PictureBox> listRata = new List<PictureBox>();
        private List<PictureBox> listNori = new List<PictureBox>();
        private const int distRata = 120, yRata = 266;
        int scor = 0;
        int cntTimp = 0;

        public frmRata()
        {
            InitializeComponent();

            listRata.Add(duck1);
            listRata.Add(duck2);
            listRata.Add(duck3);
            listRata.Add(duck4);
            listRata.Add(duck5);
            listRata.Add(duck6);
            listRata.Add(duck7);
            listRata.Add(duck8);
            //listRata.Add(duck9);

            listNori.Add(pictureBox1);
            listNori.Add(pictureBox2);
            listNori.Add(pictureBox3);
            listNori.Add(pictureBox4);
            listNori.Add(pictureBox5);
            listNori.Add(pictureBox6);

            for (int i = 1; i < 8; i++)
            {
                listRata[i].Location = new Point(listRata[i - 1].Location.X - distRata, yRata);
            }

            for (int i = 0; i < 8; i++)
                listRata[i].Tag = "1";

            timerMoveDuck.Enabled = true;
            timerMoveDuck.Start();

            timerGame.Enabled = true;
            timerGame.Start();

            timer1.Enabled = true;
            timer1.Start();

            timer3.Enabled = true;
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                if (listRata[i].Tag.ToString() == "1")
                {
                    listRata[i].Tag = "2";
                    listRata[i].Image = Atesat_v._1._1.Properties.Resources.duck2;
                }
                else
                {
                    listRata[i].Tag = "1";
                    listRata[i].Image = Atesat_v._1._1.Properties.Resources.duck1;
                }
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            int x = Cursor.Position.X - 250;

            pbGun.Location = new Point(x - 200, pbGun.Location.Y);
            pbExp.Location = new Point(Cursor.Position.X - 480, pbExp.Location.Y);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                listRata[i].Location = new Point(listRata[i].Location.X + 5, yRata);

                if (listRata[i].Location.X > frmRata.ActiveForm.Width)
                {
                    listRata[i].Location = new Point(-100, yRata);
                    listRata[i].Show();
                }
            }
        }

        private void duck1_Click(object sender, EventArgs e)
        {
            scor++;

            //listRata[0].Location = new Point(-10, yRata);
            listRata[0].Hide();
            lbScor.Text = "Scor: " + Convert.ToString(scor);

            pbExp.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void duck2_Click(object sender, EventArgs e)
        {
            scor++;

            //listRata[1].Location = new Point(-10, yRata);
            listRata[1].Hide();
            lbScor.Text = "Scor: " + Convert.ToString(scor);

            pbExp.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void duck3_Click(object sender, EventArgs e)
        {
            scor++;

            //listRata[2].Location = new Point(-10, yRata);
            listRata[2].Hide();
            lbScor.Text = "Scor: " + Convert.ToString(scor);

            pbExp.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void duck4_Click(object sender, EventArgs e)
        {
            scor++;

            //listRata[3].Location = new Point(-10, yRata);
            listRata[3].Hide();
            lbScor.Text = "Scor: " + Convert.ToString(scor);

            pbExp.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void duck5_Click(object sender, EventArgs e)
        {
            scor++;

            //listRata[4].Location = new Point(-10, yRata);
            listRata[4].Hide();
            lbScor.Text = "Scor: " + Convert.ToString(scor);

            pbExp.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void duck6_Click(object sender, EventArgs e)
        {
            scor++;

            //listRata[5].Location = new Point(-10, yRata);
            listRata[5].Hide();
            lbScor.Text = "Scor: " + Convert.ToString(scor);

            pbExp.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void duck7_Click(object sender, EventArgs e)
        {
            scor++;

            //listRata[6].Location = new Point(-10, yRata);
            listRata[6].Hide();
            lbScor.Text = "Scor: " + Convert.ToString(scor);

            pbExp.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void duck8_Click(object sender, EventArgs e)
        {
            scor++;

            //listRata[7].Location = new Point(-10, yRata);
            listRata[7].Hide();
            lbScor.Text = "Scor: " + Convert.ToString(scor);

            pbExp.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
        }

        //private void duck9_Click(object sender, EventArgs e)
        //{
        //    scor++;

        //    //listRata[8].Location = new Point(-10, yRata);
        //    listRata[8].Hide();
        //    lbScor.Text = "Scor: " + Convert.ToString(scor);

        //    pbExp.Visible = true;
        //    timer2.Enabled = true;
        //    timer2.Start();
        //}

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            pbExp.Visible = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            cntTimp++;
            lbTimp.Text = "Timp: " + Convert.ToString(cntTimp) + "s";

            if (cntTimp == 30)
            {
                Utilizator.bani += scor;

                timerMoveDuck.Enabled = false;
                timerGame.Enabled = false;
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer2.Enabled = false;

                for (int i = 0; i < listNori.Count; i++)
                    listNori[i].Visible = false;
                for (int i = 0; i < listRata.Count; i++)
                    listRata[i].Visible = false;

                pbGun.Visible = false;
                pbExp.Visible = false;

                lbTimp.Visible = false;
                lbScor.Visible = false;

                lbMonObt.Text = "Ati avut scorul " + Convert.ToString(scor) + " si ati obtinut " + Convert.ToString(scor) + " monede";
                lbMonObt.Visible = true;

                lbMonTot.Text = "Noul credit: " + Convert.ToString(Utilizator.bani) + " de monede";
                lbMonTot.Visible = true;

                pbJocNou.Visible = true;
                pbIesire.Visible = true;
            }
        }

        private void pbIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbJocNou_Click(object sender, EventArgs e)
        {
            if (Utilizator.bani >= 15)
            {
                Utilizator.bani -= 15;
                lbMonObt.Visible = false;
                lbMonTot.Visible = false;

                pbJocNou.Visible = false;
                pbIesire.Visible = false;

                for (int i = 0; i < listNori.Count; i++)
                    listNori[i].Visible = true;

                listRata[0].Location = new Point(86, 266);
                listRata[0].Visible = true;
                listRata[0].Tag = "1";
                for (int i = 1; i < listRata.Count; i++)
                {
                    listRata[i].Location = new Point(listRata[i - 1].Location.X - distRata, listRata[i].Location.Y);
                    listRata[i].Visible = true;
                    listRata[i].Tag = "1";
                }

                lbTimp.Visible = true;
                lbTimp.Text = "Timp: 0s";
                lbScor.Visible = true;
                lbScor.Text = "Scor: 0";

                pbGun.Visible = true;

                scor = 0;
                cntTimp = 0;

                timerMoveDuck.Enabled = true;
                timerMoveDuck.Start();

                timerGame.Enabled = true;
                timerGame.Start();

                timer1.Enabled = true;
                timer1.Start();

                timer3.Enabled = true;
                timer3.Start();
            }
            else
                MessageBox.Show("Credit insuficient pentru a rejuca!");
        }
    }
}
