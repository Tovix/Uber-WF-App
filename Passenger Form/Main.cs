using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uperlogin;
using project_RT;

namespace Passenger_Form
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcom we = new welcom();
            we.main = this;
            we.Show();
            this.Hide();
            login_button.Visible = false;
        }

        private void pass_driver_button_Click(object sender, EventArgs e)
        {
            if(Program.userType.ToLower() == "passenger")
            {
                RequestTrip requestTrip = new RequestTrip();
                requestTrip.main = this;
                requestTrip.Show();
                this.Hide();
            }
            else
            {
                Form1 responesTrip = new Form1();
                responesTrip.main = this;
                responesTrip.Show();
                this.Hide();
            }
        }

        private void showUsers_button_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.main = this;
            adminForm.Show();
            this.Hide();
        }

        private void showUserDetails_button_Click(object sender, EventArgs e)
        {
            if (Program.userType.ToLower() == "passenger")
            {
                passnger_trips passenger_trips = new passnger_trips();
                passenger_trips.main = this;
                passenger_trips.Show();
                this.Hide();
            }
            else
            {
                Form3 driverTrips = new Form3();
                driverTrips.main = this;
                driverTrips.Show();
                this.Hide();
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (Program.userType.ToLower() == "passenger")
            {
                pass_driver_button.Text = "Request Trip";
                showUserDetails_button.Text = "Show Trips Info";
                pass_driver_button.Visible = true;
                showUserDetails_button.Visible = true;
            }
            else if (Program.userType.ToLower() == "driver")
            {
                pass_driver_button.Text = "Find A Passnger";
                showUserDetails_button.Text = "Show Trips Info";
                pass_driver_button.Visible = true;
                showUserDetails_button.Visible = true;
            }
            else if (Program.userType.ToLower() == "admin")
            {
                showUsers_button.Visible = true;
                update_button.Visible = true;
            }
        }

        private void Main_Enter(object sender, EventArgs e)
        {
            
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            Form4 update = new Form4();
            update.main = this;
            update.Show();
        }
    }
}
