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
    public partial class frmMeniu : Form
    {
        public frmMeniu()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Start();
        }

        private void initContr()
        {
            //img
            imgSnake.Visible = false;
            imgDescopera.Visible = false;
            imgMaimuta.Visible = false;
            imgRata.Visible = false;

            //titlu
            lbTitleSnake.Visible = false;
            lbTitleDescopera.Visible = false;
            lbTitleMaimuta.Visible = false;
            lbTitleRata.Visible = false;

            //rtb
            rtbSnake.Visible = false;
            rtbDescopera.Visible = false;
            rtbMaimuta.Visible = false;
            rtbRata.Visible = false;

            //pb
            pbSnake1.Visible = false; pbSnake2.Visible = false;
            pbDescopera1.Visible = false; pbDescopera2.Visible = false;
            pbMaimuta1.Visible = false;
            pbRata.Visible = false;

            //pret
            lbPretSnake.Visible = false;
            lbPretDescopera.Visible = false;
            lbPretMaimuta.Visible = false;
            lbPretRata.Visible = false;
        }

        private void delogareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inchidereAplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbNume.Text = Utilizator.nume;
            lbJetoane.Text = Convert.ToString(Utilizator.bani);
        }

        private void snakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initContr();

            pbStart.Visible = true;

            imgSnake.Visible = true;
            lbTitleSnake.Visible = true;
            rtbSnake.Visible = true;
            pbSnake1.Visible = true;
            pbSnake2.Visible = true;
            lbPret.Visible = true;
            lbPretSnake.Text = "10 monede";
            lbPretSnake.Visible = true;
        }

        private void descoperaNumarulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initContr();

            pbStart.Visible = true;

            imgDescopera.Visible = true;
            lbTitleDescopera.Visible = true;
            rtbDescopera.Visible = true;
            pbDescopera1.Visible = true;
            pbDescopera2.Visible = true;
            lbPret.Visible = true;
            lbPretDescopera.Text = "5 monede";
            lbPretDescopera.Visible = true;
        }

        private void prindeMaimutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initContr();

            pbStart.Visible = true;

            imgMaimuta.Visible = true;
            lbTitleMaimuta.Visible = true;
            rtbMaimuta.Visible = true;
            pbMaimuta1.Visible = true;
            lbPret.Visible = true;
            lbPretMaimuta.Text = "10 monede";
            lbPretMaimuta.Visible = true;
        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            if (lbTitleSnake.Visible)
            {
                Utilizator.bani -= 10;

                frmSnake frm = new frmSnake();
                frm.Show();
            }
            else if (lbTitleDescopera.Visible)
            {
                Utilizator.bani -= 5;

                frmDescopera frm = new frmDescopera();
                frm.Show();
            }
            else if (lbTitleMaimuta.Visible)
            {
                Utilizator.bani -= 10;

                frmMaimuta frm = new frmMaimuta();
                frm.Show();
            }
            else if (lbTitleRata.Visible)
            {
                Utilizator.bani -= 15;

                frmRata frm = new frmRata();
                frm.Show();
            }
        }

        private void impuscaRateleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initContr();

            pbStart.Visible = true;

            imgRata.Visible = true;
            lbTitleRata.Visible = true;
            rtbRata.Visible = true;
            pbRata.Visible = true;
            lbPret.Visible = true;
            lbPretRata.Text = "15 monede";
            lbPretRata.Visible = true;
        }

        private void informatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfo frm = new frmInfo();
            frm.Show();
        }

    }
}
