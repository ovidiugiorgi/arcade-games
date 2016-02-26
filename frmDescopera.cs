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
    public partial class frmDescopera : Form
    {
        int cnt = 0, num, semn = 0, nr;
        string s;

        public frmDescopera()
        {
            InitializeComponent();
        }

        private bool verificareTB()
        {
            if (s.Length == 0)
            {
                MessageBox.Show("Introduceti un interval.");
                return false;
            }
               
            for (int i = 0; i < s.Length; i++)
            {
                if (!(s[i] >= '0' && s[i] <= '9'))
                {
                    MessageBox.Show("Introduceti un interval valid.");
                    tbL.Clear();
                    tbR.Clear();
                    return false;
                }
            }
            return true;
        }


        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int l = 0, r = 0;

            s = tbL.Text;
            if (verificareTB()) l = Convert.ToInt32(s);
            else return;

            s = tbR.Text;
            if (verificareTB()) r = Convert.ToInt32(s);
            else return;

            if (r <= l)
            {
                MessageBox.Show("Capatul superior al intervalului trebuie sa fie strict mai mare decat capatul inferior. Introduceti alt interval.");
                tbL.Clear();
                tbR.Clear();
            }
            else
            {
                pbSet.Visible = false;
                tbL.Visible = false;
                pbLiniuta.Visible = false;
                tbR.Visible = false;
                pbOk.Visible = false;

                schimbareChestii(true);

                Random rnd = new Random();
                num = rnd.Next(l, r + 1);

                lbInterval.Text = "Intervalul: [" + Convert.ToString(l) + ", " + Convert.ToString(r) + "]";
            }
        }

        private void schimbareChestii(bool stance)
        {
            lbEste.Visible = stance;
            pb1.Visible = stance;
            pb2.Visible = stance;
            pb3.Visible = stance;
            tbNr.Visible = stance;
            pbIntreaba.Visible = stance;
            pbRenunta.Visible = stance;
            lbInterval.Visible = stance;
            lbIntrebare.Visible = stance;
            lbNrIntrebari.Visible = stance;
            lbRaspuns.Visible = stance;
        }

        private void initImagini()
        {
            pb1.Image = Atesat_v._1._1.Properties.Resources.egal;
            pb2.Image = Atesat_v._1._1.Properties.Resources.mare;
            pb3.Image = Atesat_v._1._1.Properties.Resources.mic;

            semn = 0;
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            initImagini();
            pb1.Image = Atesat_v._1._1.Properties.Resources.egalR;
            semn = 1;
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            initImagini();
            pb2.Image = Atesat_v._1._1.Properties.Resources.mareR;
            semn = 2;
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            initImagini();
            pb3.Image = Atesat_v._1._1.Properties.Resources.micR;
            semn = 3;
        }

        private void pbIntreaba_Click(object sender, EventArgs e)
        {
            if (semn == 0) MessageBox.Show("Selectati un semn de comparatie pentru a pune o intrebare.");
            else
            {
                s = tbNr.Text;
                if (s.Length == 0)
                {
                    MessageBox.Show("Introduceti un numar.");
                    return;
                }
                for (int i = 0; i < s.Length; i++)
                {
                    if (!(s[i] >= '0' && s[i] <= '9'))
                    {
                        MessageBox.Show("Introduceti un numar valid.");
                        tbNr.Clear();
                        return;
                    }
                }

                nr = Convert.ToInt32(s);

                if (semn == 1)
                {
                    if (num == nr)
                    {
                        cnt++;

                        Utilizator.bani += 20;

                        schimbareChestii(false);

                        lbFel.Text = "Felicitari, ati descoperit numarul " + Convert.ToString(num);
                        if (cnt == 1)
                        {
                            lbFel1.Text = "din o intrebare";
                            Utilizator.bani += 80;
                        }
                        else lbFel1.Text = "din " + Convert.ToString(cnt) + " intrebari!";
                        lbFel.Visible = true;
                        lbFel1.Visible = true;
                        lbFel2.Visible = true;
                        lbFel2.Text = "Ati primit 20 de monede";
                        lbFel3.Visible = true;
                        lbFel3.Text = "Noul credit: " + Convert.ToString(Utilizator.bani) + " monede";

                        pbJocNou.Visible = true;
                        pbIesire.Visible = true;
                    }
                    else
                    {
                        lbNrIntrebari.Text = "Nr. de intrebari " + Convert.ToString(cnt);

                        lbIntrebare.Text = "Ultima intrebare: Este egal cu " + Convert.ToString(nr) + "?";
                        lbRaspuns.Text = "Ultimul raspuns: NU";
                    }
                }
                else if (semn == 2)
                {
                    cnt++;
                    lbNrIntrebari.Text = "Nr. de intrebari " + Convert.ToString(cnt);

                    lbIntrebare.Text = "Ultima intrebare: Este mai mare decat " + Convert.ToString(nr) + "?";

                    if (num > nr)
                        lbRaspuns.Text = "Ultimul raspuns: DA";
                    else
                        lbRaspuns.Text = "Ultimul raspuns: NU";
                }
                else if (semn == 3)
                {
                    cnt++;
                    lbNrIntrebari.Text = "Nr. de intrebari " + Convert.ToString(cnt);

                    lbIntrebare.Text = "Ultima intrebare: Este mai mic decat " + Convert.ToString(nr) + "?";

                    if (num < nr)
                        lbRaspuns.Text = "Ultimul raspuns: DA";
                    else
                        lbRaspuns.Text = "Ultimul raspuns: NU";
                }

                initImagini();
            }
        }

        private void pbJocNou_Click(object sender, EventArgs e)
        {
            if (Utilizator.bani >= 5)
            {
                Utilizator.bani -= 5;
                cnt = 0;
                num = 0;

                lbRenunta.Visible = false;
                lbFel.Visible = false;
                lbFel1.Visible = false;
                lbFel2.Visible = false;
                lbFel3.Visible = false;
                pbJocNou.Visible = false;
                pbIesire.Visible = false;

                pbSet.Visible = true;
                tbL.Visible = true;
                pbLiniuta.Visible = true;
                tbR.Visible = true;
                pbOk.Visible = true;

                tbL.Clear();
                tbR.Clear();
                tbNr.Clear();
                lbIntrebare.Text = "Ultima intrebare: -";
                lbRaspuns.Text = "Ultimul raspuns: -";
                lbNrIntrebari.Text = "Nr. de intrebari: 0";
            }
            else
            {
                MessageBox.Show("Nu aveti destule monede pentru a juca din nou.");
            }
        }

        private void pbIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRenunta_Click(object sender, EventArgs e)
        {
            schimbareChestii(false);

            lbRenunta.Text = "Numarul cautat era " + Convert.ToString(num);
            lbRenunta.Visible = true;
            lbFel2.Visible = true;
            lbFel2.Text = "Ati primit 0 monede";
            lbFel3.Visible = true;
            lbFel3.Text = "Noul credit: " + Convert.ToString(Utilizator.bani) + " monede";

            pbJocNou.Visible = true;
            pbIesire.Visible = true;
        }
    }
}
