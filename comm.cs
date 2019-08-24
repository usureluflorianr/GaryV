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
    public partial class comm : Form
    {
        Thread th;

        public comm()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=GTvVlcSHxwJnPzWNsvkztBmQhkHlqDfRQCWbNpqwzRtzdPslgdNKNQdfPhnKmxkjtVgHXsrHHNhQX");
        }

        private void comm_Load(object sender, EventArgs e)
        {

        }
    }
}
