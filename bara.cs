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

namespace WindowsFormsApp1
{
    public partial class bara : Form
    {
        Thread th;

        public bara()
        {
            InitializeComponent();
            timer1.Start();
            button1.Enabled = false;
            if(progressBar1.Value == 100)
            {
                label1.Text = "0%";
                progressBar1.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1); 
            if(progressBar1.Value == 100)
            {
                label1.Text = "100%";
                button1.Enabled = true; 
                timer1.Stop();
            }
            else
            {
                button1.Enabled = false; 
                label1.Text = progressBar1.Value + "%";
            }
        }

        private void usu(object obj)
        {
            Application.Run(new gata());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start(); 
        }

        private void bara_Load(object sender, EventArgs e)
        {

        }
    }
}
