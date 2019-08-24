using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using System.Threading;


namespace WindowsFormsApp1
{

    public partial class GaryV : Form
    {
        Thread th;
        private SoundPlayer player;
       
        
        public GaryV()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            player = new SoundPlayer("fundal.wav");
            player.PlayLooping();

        }



        private void GaryV_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            player.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100005252507150");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

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
        private void usu1(object obj)
        {
            Application.Run(new Story());
        }
        private void usu2(object obj)
        {
            Application.Run(new Form9());
        }
        private void usu3(object obj)
        {
            Application.Run(new salvation());
        }

        private void usu4(object obj)
        {
            Application.Run(new comm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void usu5(object obj)
        {
            Application.Run(new game2());
        }
    }
}
