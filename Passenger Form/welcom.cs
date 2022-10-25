using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Passenger_Form;

namespace uperlogin
{
    public partial class welcom : Form
    {
        private string s1 = "";
        private int len = 0;
        int fw = 0, wh = 0;
        public Main main;
        public welcom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.location = this.Location;
            Program.size = this.Size;
            s1 = label1.Text;
            label1.Text = "";
            timer1.Start();
            fw = this.Width;
            wh = this.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < s1.Length)
            {
                label1.Text += s1.ElementAt(len);
                len++;
            }
            else
            {
                timer1.Stop();
                TypeSelection typeSelection = new TypeSelection();
                typeSelection.main = main;
                typeSelection.Show();
                this.Hide();
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            Program.location = this.Location;
            Program.size = this.Size;
        }

        private void welcom_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Program.location = this.Location;
            Program.size = this.Size;

        }
    }
}
