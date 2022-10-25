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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Main main;
        // Connection Initiation:
        // =======================
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        // Online/Offline Property Check:
        // ==============================
        private bool _availability;
        public bool available
        {
            get
            {
                return _availability;
            }
            set
            {
                _availability = value;
                textBox4.Text = _availability ? "Online" : "Offline";
                string message = _availability ? "Gone Online Successfully!" : "Gone Offline Successfully!";
                MessageBox.Show(message);   
            }
        }
        // Main Functions:
        // ===============
        private OracleDataReader oracleSelectCommand(string command, string parameter = null, string selectedItem = null)
        {
            OracleCommand oracleCommand1 = new OracleCommand();
            oracleCommand1.Connection = conn;
            oracleCommand1.CommandText = command;
            oracleCommand1.CommandType = CommandType.Text;
            if (parameter != null && selectedItem != null)
            {
                oracleCommand1.Parameters.Add(parameter, selectedItem);
            }
            OracleDataReader dr = oracleCommand1.ExecuteReader();
            return dr;
        }
        private int oracleNonQueryCommand(string command, List<string> parameters, List<string> selectedItems) 
        {
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = conn;
            oracleCommand.CommandText =command;
            oracleCommand.CommandType = CommandType.Text;
            for(int i = 0; i < parameters.Count; i++) 
            {
                oracleCommand.Parameters.Add(parameters[i], selectedItems[i]);
            }
            int r = oracleCommand.ExecuteNonQuery();
            return r;
        }
        private void loadingData() 
        {
            if (available)
            {
                OracleDataReader dr = oracleSelectCommand("select username from users u where u.ssn in (select passenger_ssn from trip where trip.status = 'not accepted')");
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0]);
                }
                dr.Close();
            }
        }
        // Form initiation:
        // ================
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Events initiation once the form loads:
            // ======================================
            conn = new OracleConnection(ordb);
            conn.Open();
            loadingData();
        }
        // Events initiation when the index of item of combobox1 is selected:
        // ==================================================================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataReader dr1 = oracleSelectCommand("select phone_number from users where username =:un", "un",comboBox1.SelectedItem.ToString());
            if (dr1.Read())
            {
                textBox2.Text = dr1[0].ToString();
            }
            dr1.Close();
            OracleDataReader dr2 = oracleSelectCommand
                ("select pickup_location, destination from trip where passenger_ssn in (select ssn from users where username=:usr)", "usr", comboBox1.SelectedItem.ToString());
            if(dr2.Read())
            {
                textBox3.Text = dr2[0].ToString();
                textBox1.Text = dr2[1].ToString();
            }
            dr2.Close();
        }
        // Events initiation when the notification button is clicked:
        // ==========================================================
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        // Events initiation when the Online/Offline button is clicked:
        // ============================================================
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            available = !available;
            loadingData();
        }
        // Events initiation when the accept Trip button is clicked:
        // ==========================================================
        private void button4_Click(object sender, EventArgs e)
        {

            string timeNow = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
            string timeLater = string.Format("{0:HH:mm:ss tt}", DateTime.Now.AddHours(2));

            List<string> parametersList = new List<string>{"strt", "end", "usr"};
            List<string> selectedItemsList = new List<string> { timeNow, timeLater, comboBox1.SelectedItem.ToString() };
            int r = oracleNonQueryCommand
                ("UPDATE trip t SET t.STATUS = 'accepted', t.start_time=:strt, t.end_time =:end WHERE t.passenger_ssn IN (SELECT ssn FROM users u WHERE u.username=:usr)"
                ,parametersList, selectedItemsList);
            if (r != -1)
            {
                MessageBox.Show("Trip Accepted!");
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            
           
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
