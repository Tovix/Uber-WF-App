using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passenger_Form
{
    public partial class passnger_trips : Form
    {
        public Main main;
        UserTrips userTrips;
        public passnger_trips()
        {
            InitializeComponent();
        }

        private void passnger_trips_Load(object sender, EventArgs e)
        {
            userTrips = new UserTrips();
            userTrips.SetParameterValue(0, Program.currentuserssn);
            crystalReportViewer1.ReportSource = userTrips;
        }

        private void passnger_trips_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
