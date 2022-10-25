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
    public partial class TypeSelection : Form
    {
        public Main main;
        public TypeSelection()
        {
            InitializeComponent();
        }

        

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = Program.location;
            this.Size = Program.size;
            
            panel5.BackColor = Color.FromArgb(246, 246, 246, 246);
        }

        

        private  void  panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gray;
            label2.ForeColor = Color.White;
            panel6.Visible = false;
            timer1.Start();

        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            label2.ForeColor = Color.Black;
            panel6.Visible = true;
            timer1.Stop();
            pictureBox2.Location = new Point(3, 3);

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Gray;
            label1.ForeColor = Color.White;
            panel4.Visible = false;
            timer2.Start();



        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            panel4.Visible = true;
            timer2.Stop();
            pictureBox3.Location = new Point(3, 3);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Program.userType = "Driver";
            login log = new login();
            log.main = main;
            log.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Program.userType = "passenger";
            login log = new login();
            log.main = main;
            log.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X + 2, pictureBox2.Location.Y);
            if (pictureBox2.Location.X > 70)
            {
                pictureBox2.Location = new Point(-50, 3);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(pictureBox3.Location.X + 2, pictureBox3.Location.Y);
            if (pictureBox3.Location.X > 70)
            {
                pictureBox3.Location = new Point(-50, 3);
            }
        }

        private void Form3_Move(object sender, EventArgs e)
        {
            Program.location = this.Location;
            Program.size = this.Size;
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            Program.location = this.Location;
            Program.size = this.Size;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
