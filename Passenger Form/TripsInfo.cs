using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Passenger_Form
{
    public partial class Form2 : Form
    {
        string passenger_ssn = "20147463599704";
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string ordb = "Data Source = orcl; User Id = scott; Password = tiger;";
            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand comm = new OracleCommand();
            comm.Connection = conn;
            comm.CommandText = "select trip_date from Trip";
            comm.CommandType = CommandType.Text;
            OracleDataReader dr = comm.ExecuteReader();
            while(dr.Read())
            {
                cmb_showInfo.Items.Add(dr[0].ToString());
                int i = 0;
                i++;
            }
            conn.Close();
        }

        private void btn_showInfo_Click(object sender, EventArgs e)
        {
            if (cmb_showInfo.Text != "")
            {
                string ordb = "Data Source = orcl; User Id = scott; Password = tiger;";
                string cmdstr = "select trip_id, uname, gender, pickup_location, destination," +
                                " start_time, end_time" +
                                " from Trip, Driver, users " +
                                "where driver_ssn = user_ssn and user_ssn = ssn and " +
                                "passenger_ssn = :ssn and trip_date = :trip_date";

                OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, ordb);
                adapter.SelectCommand.Parameters.Add("ssn", passenger_ssn);
                adapter.SelectCommand.Parameters.Add("trip_date", cmb_showInfo.SelectedItem.ToString());
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv_show.DataSource = ds.Tables[0];
                /*dgv_show.Columns[0].Width = 200;*/
            }
            else
            {
                error_label.Visible = true;
            }
        }

        private void cmb_showInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            error_label.Visible = false;
        }
    }
}
