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
    public partial class Admin : Form
    {
        UsersReport userReport;
        public Main main;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.Hide();
            userReport = new UsersReport();
        }

        private void show_button_Click(object sender, EventArgs e)
        {
            if(input_textBox.Text != "")
            {
                try
                {
                    userReport.SetParameterValue(0, int.Parse(input_textBox.Text));
                    crystalReportViewer1.ReportSource = userReport;
                    crystalReportViewer1.Show();

                } catch
                {
                    error_label.Visible = true;
                    crystalReportViewer1.Hide();
                }
            }
        }

        private void input_textBox_TextChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
