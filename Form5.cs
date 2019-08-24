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

namespace WindowsFormsApp1
{
    public partial class Story3 : Form
    {
        Thread th;

        public Story3()
        {
            InitializeComponent();
        }

        private void Story3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void usu1(object obj)
        {
            Application.Run(new Story2());
        }

        private void usu2(object obj)
        {
            Application.Run(new Story4());
        }
    }
}
