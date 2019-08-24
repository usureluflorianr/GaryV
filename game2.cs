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
    public partial class game2 : Form
    {
        Thread th;
        private SoundPlayer player;

        public game2()
        {
            InitializeComponent();
            player = new SoundPlayer("mozart.wav");
            player.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void usu1(object obj)
        {
            Application.Run(new GaryV());
        }

        private void usu2(object obj)
        {
            Application.Run(new t1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Sound: OFF";
                player.Stop();
            }
            else
            {
                checkBox1.Text = "Sound: ON";
                player.PlayLooping();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void game2_Load(object sender, EventArgs e)
        {

        }
    }
}
