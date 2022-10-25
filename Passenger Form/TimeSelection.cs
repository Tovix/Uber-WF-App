using System;
using System.Drawing;
using System.Windows.Forms;

namespace Passenger_Form
{
    public partial class TimeSelection : Form
    {
        public delegate void TimeConfirmedEventHandler(object source, Time time);
        public event TimeConfirmedEventHandler TimeConfirmed;
        private void TimeSelection_Load(object sender, EventArgs e)
        {
            this.Size = new Size(483, 171);
        }
        public TimeSelection()
        {
            InitializeComponent();
        }

        private void now_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            errorTime_label.Visible = false;
        }

        private void custom_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(custom_radioButton.Checked)
            {
                Time currTime = Time.CurrentTime();
                date_coboBox.Items.Add(currTime.date);
                for (int i = 1; i < 7; i++)
                {
                    date_coboBox.Items.Add(DateTime.Now.AddDays((double)i).ToString("dddd, dd MMMM"));
                }
                date_coboBox.Text = date_coboBox.Items[0].ToString();
                am_pm_comboBox.Text = currTime.am_or_pm;
                hours_comboBox.Text = currTime.hours.TrimStart('0');
                minutes_comboBox.Text = currTime.minutes.TrimStart('0');
                this.Size = new Size(483, 252);
                customTime_panel.Visible = true;
            }
            else
            {
                this.Size = new Size(483, 171);
                customTime_panel.Visible = false;
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (now_radioButton.Checked || Time.validTime(getSelectedTime()))
            {
                errorTime_label.Visible = false;
                onTimeConfirmed();
                this.Close();
            }
            else
                errorTime_label.Visible = true;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeSelection_Shown(object sender, EventArgs e)
        {
            confirm_button.Focus();
        }

        protected virtual void onTimeConfirmed()
        {
            if (TimeConfirmed != null)
            {
                Time time = null;
                bool now = false;
                if (now_radioButton.Checked)
                    now = true;
                else
                {
                    time = getSelectedTime();
                    now = Time.isCurrentTime(time);
                }
                TimeConfirmed(this, new Time(time, now));
            }
        }

        private Time getSelectedTime()
        {
            return new Time(date_coboBox.SelectedItem.ToString(),
            hours_comboBox.SelectedItem.ToString(), minutes_comboBox.SelectedItem.ToString(),
            am_pm_comboBox.SelectedItem.ToString(), false);
        }
    }
}
