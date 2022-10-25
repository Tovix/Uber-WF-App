using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Passenger_Form
{
    public partial class RequestTrip : Form
    {
        public Main main;
        public static string passenger_ssn;
        GMapOverlay markers = new GMapOverlay("markers");
        bool validLocation = false;
        public RequestTrip()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dest_textBox.TabStop = false;
        }

        private void dest_textBox_Leave(object sender, EventArgs e)
        {
            if (dest_textBox.Text.Trim() == "")
            {
                dest_textBox.Text = "إلى أين ؟";
                dest_textBox.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        private void dest_textBox_Click(object sender, EventArgs e)
        {
            if (dest_textBox.Text == "إلى أين ؟")
            {
                dest_textBox.Text = "";
                dest_textBox.ForeColor = Color.Black;
            }
        }

        private void TimeSelect_MouseLeave(object sender, EventArgs e)
        {
            panel_time.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void TimeSelect_MouseEnter(object sender, EventArgs e)
        {
            panel_time.BackColor = Color.FromArgb(210, 210, 210);
        }

        private void TimeSelect_Click(object sender, EventArgs e)
        {
            TimeSelection timeSelection = new TimeSelection();
            Point position = new Point(this.Location.X + panel_dest.Location.X + 9, 
                this.Location.Y + panel_dest.Location.Y + panel_dest.Height + 38);
            timeSelection.Location = position;
            timeSelection.TimeConfirmed += this.onTimeConfirmed;
            timeSelection.ShowDialog();
        }

        private void onTimeConfirmed(object source, Time time)
        {
            if(time.now)
            {
                time_label.Text = "";
                panel_time.Size = new Size(146, panel_time.Size.Height);
                now_label.Text = "Now";
            }
            else
            {
                time_label.Text = time.date + " - " + time.hours.PadLeft(2, '0') + ":" + 
                    time.minutes.PadLeft(2, '0') + " " + time.am_or_pm;
                panel_time.Size = new Size(146 + 30, panel_time.Size.Height);
                now_label.Text = "Custom";
            }
        }

        private void confirmTrip_button_Click(object sender, EventArgs e)
        {
            if(validLocation)
            {
                //hide the button
                confirmTrip_button.Visible = false;

                //get a random location from the list of locations
                int desIndex = dest_textBox.AutoCompleteCustomSource.IndexOf(dest_textBox.Text.ToString());
                Random random = new Random();
                int pickup_location_index;
                do
                {
                    pickup_location_index = random.Next(0, 270);
                } while (pickup_location_index == desIndex);
                string pickup_location = dest_textBox.AutoCompleteCustomSource[pickup_location_index];

                //insert the trip into database
                string ordb = "Data Source = orcl; User Id = scott; Password = tiger;";
                OracleConnection conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand comm = new OracleCommand();
                comm.Connection = conn;
                comm.CommandText = "insert into Trip " +
                    "(trip_id, passenger_ssn, pickup_location, destination)" +
                    "values(:id, :ssn, :pickup_location, :destination)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.Add("id", Guid.NewGuid().ToString("N"));
                comm.Parameters.Add("ssn", passenger_ssn);
                comm.Parameters.Add("pickup_location", Encoding.encode(pickup_location));
                comm.Parameters.Add("destination", Encoding.encode(dest_textBox.Text.ToString()));
                int dr = comm.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                //show an error message
                errorLoc_label.Visible = true;
            }
        }

        private async void dest_textBox_TextChanged(object sender, EventArgs e)
        {
            confirmTrip_button.Visible = true; 
            if (dest_textBox.AutoCompleteCustomSource.Contains(dest_textBox.Text.ToString()))
            {
                validLocation = true;
                errorLoc_label.Visible = false;

                //get coordinates of location
                var coordinates = await Geocoding.getCoordinates(dest_textBox.Text.ToString());

                //show location on map
                map.Visible = true;
                getmap(coordinates.latitude, coordinates.longitude);

            }
            else
            {
                map.Visible = false;
                validLocation = false;
            }
        }

        public void getmap(string lat, string lng)
        {
            //to Hide Red Cross in Center of map 
            removePointAndMarker();
            map.ShowCenter = false;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng));
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
            PointLatLng point = new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng));
            //create a Overlay
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);
            //Add all available markers to that Overlay
            markers.Markers.Add(marker);
            //Cover map with Overlay
            map.Overlays.Add(markers);

        }
        public void removePointAndMarker()
        {
            markers.Markers.Clear();
            map.Refresh();
        }

        private void RequestTrip_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
