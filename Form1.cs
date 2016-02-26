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
    public partial class Form1 : Form
    {
        int cnt = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
        }

        public void startTimer()
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;
            if (pictureBox1.Visible == true) pictureBox1.Visible = false;
            else pictureBox1.Visible = true;
            if (cnt == 7)
            {
                timer1.Stop();
                pictureBox1.Visible = false;
                label4.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                pictureBox3.Visible = true;
                pictureBox2.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
            //MessageBox.Show(Convert.ToString(e.KeyCode));
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Input.KeyPressed(Keys.Space))
            {
                Input.ChangeState(Keys.Space, false);
                frmMeniu frm = new frmMeniu();
                frm.Show();

                label1.Visible = false;
                label4.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox1.Clear();
                pictureBox3.Visible = true;
                textBox1.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox2.Visible = true;
                pictureBox2.Enabled = true;

                timer2.Stop();
                timer2.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(textBox1.Text);
            if (textBox1.Text.Length > 0)
            {
                Utilizator.nume = name;
                Utilizator.bani = 100;
                label1.Text = "Buna, " + name + "!\nApasati SPACE pentru a incepe.";
                label1.Visible = true;
                label4.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox1.Enabled = false;
                pictureBox3.Visible = false;
                pictureBox3.Enabled = false;
                pictureBox2.Visible = false;
                pictureBox2.Enabled = false;

                timer2.Enabled = true;
                timer2.Start();
            }
            else
            {
                MessageBox.Show("Introduceti un nume.");
                textBox1.Clear();
            }
        }
    }
}
