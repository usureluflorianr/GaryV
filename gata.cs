using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class gata : Form
    {
        Thread th;
        int score, bit;
        public gata()
        {
            InitializeComponent();

            using (StreamReader reader = new StreamReader("pap.ini"))
            {
                score = int.Parse(reader.ReadToEnd());
                label3.Text = Convert.ToString(score);
                reader.Close();
                using (StreamWriter writer = new StreamWriter("pap.ini"))
                {
                    writer.Write(label3.Text);
                    writer.Close();
                }
            }

            using (StreamReader reader = new StreamReader("pap2.ini"))
            {
                score = int.Parse(reader.ReadToEnd());
                label5.Text = Convert.ToString(score);
                reader.Close();
                using (StreamWriter writer = new StreamWriter("pap2.ini"))
                {
                    writer.Write(label5.Text);
                    writer.Close();
                }
            }

            using (StreamReader reader = new StreamReader("pap3.ini"))
            {
                score = int.Parse(reader.ReadToEnd());
                reader.Close();
            }

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label6.Text = "- you got no fire, you got no KFC menu;" ;
            else label6.Text = "- you got fire, you survive during the winter;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label7.Text = "- you got well prepared politicians who can lead you;";
            else label7.Text = "- your politicians are easily coruptible;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label8.Text = "- you can not understand Spanish soup operas;";
            else label8.Text = "- you can easily learn Italian;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label10.Text = "- you saved millions from the plague;";
            else label10.Text = "- you've just spread the plague all over the Europe;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label11.Text = "- you can't buy Jordans because you got no money;";
            else label11.Text = "- you can invest you paper money in cryptocurrency;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label12.Text = "- there's no American dream anymore;";
            else label12.Text = "- you can eat hotdogs in Central Park;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label13.Text = "- there are no taxi drivers, because there are no factories to build cars;";
            else label13.Text = "- you can buy cheap cheese;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label14.Text = "- we have Eminem and Snoop Dog with English accent;";
            else label14.Text = "- America becomes one of the greatest power;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label16.Text = "- amazing figures like: Lebron, Obama or Rihanna rules;";
            else label16.Text = "- there are no movies with Morgan Freeman, because he's not free;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label17.Text = "- we don't have Nobel prizes;";
            else label17.Text = "- we have a world with dynamite in use;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label18.Text = "- you've drasticaly reduced polutlion;";
            else label18.Text = "- there are no plastic lego toys at all;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label19.Text = "- there are no warplanes (see WWII);";
            else label19.Text = "- we can travel by plane all over the world;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label20.Text = "- the society invested (let's hope) in education, not in WWI;";
            else label20.Text = "- we've descovered several tehnologies due to WWI;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label21.Text = "- you can't call your mom, because there are not satelites;";
            else label21.Text = "- we have satelites and we can watch Dan Negru yearly basis;";

            if (score % 2 == 1) bit = 1; 
            else bit = 0;
            score = score / 2;
            if (bit == 1) label22.Text = "- there are no Erasmus projects;";
            else label22.Text = "- we can easily visit almost anyone in this continet;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label23.Text = "- we can't make flames on Snap, because we have no internet;";
            else label23.Text = "- we can learn everything using the internet, even how to pick up girls;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label24.Text = "- we can visit Philippe Petit's favourite place;";
            else label24.Text = "- we live in fear because of the terrorists;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label25.Text = "- we are not addicted to smatphones, because they do not exist;";
            else label25.Text = "- we watch videos with cats on daily basis;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label26.Text = "- we live in a safer world the illegal migration;";
            else label26.Text = "- we live in fear because we do not understand te muslims;";

            if (score % 2 == 1) bit = 1;
            else bit = 0;
            score = score / 2;
            if (bit == 1) label26.Text = "- our leaders keep up with the evolution;";
            else label26.Text = "- we suffer from security governmental attacks;";

            label27.Text = "- Usurelu has better posts than RaduDo.";
        }

        private void usu(object obj)
        {
            Application.Run(new GaryV());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(usu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void gata_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
