﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class t8 : Form
    {
        Thread th;

        public t8()
        {
            InitializeComponent();
            progressBar1.Value = 35; 
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int score;

        private void usu(object obj)
        {
            Application.Run(new t9());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("pap3.ini"))
            {
                score = int.Parse(reader.ReadToEnd());
                score = score + 128;
                label2.Text = Convert.ToString(score);
                reader.Close();
                using (StreamWriter writer = new StreamWriter("pap3.ini"))
                {
                    writer.Write(label2.Text);
                    writer.Close();
                }
            }

            using (StreamReader reader = new StreamReader("pap.ini"))
            {
                score = int.Parse(reader.ReadToEnd());
                score =score - 100;
                label2.Text = Convert.ToString(score);
                reader.Close();
                using (StreamWriter writer = new StreamWriter("pap.ini"))
                {
                    writer.Write(label2.Text);
                    writer.Close();
                }
            }

            using (StreamReader reader = new StreamReader("pap2.ini"))
            {
                score = int.Parse(reader.ReadToEnd());
                score =score - 2;
                label3.Text = Convert.ToString(score);
                reader.Close();
                using (StreamWriter writer = new StreamWriter("pap2.ini"))
                {
                    writer.Write(label3.Text);
                    writer.Close();
                }
            }

            this.Close();
            th = new Thread(usu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("pap.ini"))
            {
                score = int.Parse(reader.ReadToEnd());
                score =score - 0;
                label2.Text = Convert.ToString(score);
                reader.Close();
                using (StreamWriter writer = new StreamWriter("pap.ini"))
                {
                    writer.Write(label2.Text);
                    writer.Close();
                }
            }

            using (StreamReader reader = new StreamReader("pap2.ini"))
            {
                score = int.Parse(reader.ReadToEnd());
                score =score - 0;
                label3.Text = Convert.ToString(score);
                reader.Close();
                using (StreamWriter writer = new StreamWriter("pap2.ini"))
                {
                    writer.Write(label3.Text);
                    writer.Close();
                }
            }

            this.Close();
            th = new Thread(usu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void t8_Load(object sender, EventArgs e)
        {

        }
    }
}
