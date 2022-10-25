using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Passenger_Form;

namespace uperlogin
{
    public partial class Form4 : Form
    {
        public Main main;
        string ordb = "Data Source = orcl; User Id = scott; Password = tiger;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder cmdBuilder;
        DataSet ds;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmdstr = "select * from users";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            /*ds.Tables[0].Rows.Add(name.Text, ssn.Text, "M", username.Text, password.Text, 0, phone.Text);*/
            dataGridView1.DataSource = ds.Tables[0];
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
                cmdBuilder=new OracleCommandBuilder(adapter);
                adapter.Update(ds.Tables[0]);                  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
    }
}
