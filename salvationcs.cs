using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class salvation : Form
    {
        Thread th;
        private SoundPlayer player2;

        public salvation()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            player2 = new SoundPlayer("metin1.wav");
            player2.PlayLooping();
        }

        private void salvation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void usu(object obj)
        {
            Application.Run(new GaryV());
        }
        private void usu1(object obj)
        {
            Application.Run(new flappy());
        }
        private void usu2(object obj)
        {
            Application.Run(new flappy7());
        }
        private void usu3(object obj)
        {
            Application.Run(new flappy8());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Sound: OFF";
                player2.Stop();
            }
            else
            {
                checkBox1.Text = "Sound: ON";
                player2.PlayLooping();
            }
        }
    }
}
