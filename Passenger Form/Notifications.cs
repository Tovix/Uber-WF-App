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
namespace project_RT
{
 
    public partial class Form2 : Form
    {
        // Form initiation:
        // ================
        public Form2()
        {
            InitializeComponent();
        }
        // Connection Initiation:
        // =======================
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection conn;
        private List<TextBox> TextBoxList = new List<TextBox>();
        // Main Functions:
        // ===============
        private void loadNotificationData() 
        {
            TextBoxList.Add(textBox1);
            TextBoxList.Add(textBox2);
            TextBoxList.Add(textBox3);
            TextBoxList.Add(textBox4);
            TextBoxList.Add(textBox5);
            TextBoxList.Add(textBox6);

            conn = new OracleConnection(ordb);
            conn.Open();
            Random random = new Random();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = conn;
            oracleCommand.CommandText = "select username from users u where u.ssn in (select passenger_ssn from trip where trip.status = 'not accepted')";
            oracleCommand.CommandType = CommandType.Text;
            var userList = new List<string>();
            using (var reader = oracleCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var username = reader[0].ToString();
                    userList.Add(username);
                }
            }
            var randomUserList = userList.OrderBy(user => random.Next()).ToList();
            for(int i = 0; i < randomUserList.Count && i < 6; i++) 
            {
                TextBoxList[i].Text = randomUserList[i];
            }
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Events initiation when the reload button is clicked:
        // ====================================================
        private void button1_Click(object sender, EventArgs e)
        {
            loadNotificationData();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
