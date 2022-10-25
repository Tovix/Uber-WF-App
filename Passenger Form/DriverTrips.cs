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
using Passenger_Form;

namespace project_RT
{
    public partial class Form3 : Form
    {
        public Main main;
        OracleConnection con;
        string ordb = "data source = orcl ; user id = scott ; password = tiger;";

        public Form3()
        {
            InitializeComponent();
   
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "GET_TRIPS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("trip_id", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("tripData", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();

            }
            dr.Close();
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "GET_TRIP_ID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Driver_ssn", textBox1.Text.ToString());
            cmd.Parameters.Add("trips_id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(dr[1].ToString() == textBox1.Text) 
                {
                    comboBox1.Items.Add(dr[0].ToString());
                }
                
            }
            dr.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
