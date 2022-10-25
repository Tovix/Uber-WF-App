using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using  Passenger_Form;

namespace uperlogin
{
    public partial class login : Form
    {
        public Main main;
        string ordb = "Data Source = orcl; User Id = scott; Password = tiger;";
        OracleConnection conn;

        public login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = Program.location;
            this.Size = Program.size;
            alphaBlendTextBox1.ForeColor = Color.Gray;
            alphaBlendTextBox1.Text = "Username";
            alphaBlendTextBox2.PasswordChar = '\0';
            alphaBlendTextBox2.ForeColor = Color.Gray;

            alphaBlendTextBox2.Text = "Password";


        }
        

       

        private void button2_Click(object sender, EventArgs e)
        {
            if(alphaBlendTextBox2.PasswordChar == '\0')
            {
                button3.BringToFront();
                alphaBlendTextBox2.PasswordChar = '*';

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.PasswordChar == '*')
            {
                button2.BringToFront();
                alphaBlendTextBox2.PasswordChar = '\0';

            }

        }

        private void alphaBlendTextBox1_Enter(object sender, EventArgs e)
        {
            if(alphaBlendTextBox1.Text== "Username"&& alphaBlendTextBox1.ForeColor == Color.Gray)
            {
                alphaBlendTextBox1.ForeColor = Color.Gold;
                alphaBlendTextBox1.Text = "";
            }
        }

        private void alphaBlendTextBox1_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "")
            {
                alphaBlendTextBox1.ForeColor = Color.Gray;
                alphaBlendTextBox1.Text = "Username";
            }
        }

        private void alphaBlendTextBox2_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "Password" && alphaBlendTextBox2.ForeColor == Color.Gray)
            {
                alphaBlendTextBox2.ForeColor = Color.Gold;
                alphaBlendTextBox2.Text = "";
                alphaBlendTextBox2.PasswordChar = '*';

            }
        }

        private void alphaBlendTextBox2_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "")
            {
                alphaBlendTextBox2.ForeColor = Color.Gray;
                alphaBlendTextBox2.PasswordChar = '\0';
                alphaBlendTextBox2.Text = "Password";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "admin" &&
                alphaBlendTextBox2.Text == "admin")
            {
                Program.userType = "Admin";
                this.Close();
            }
            else
            {
                bool flag = check_password2();
                // if flag = true :succssesful login else faild login
                if (flag)
                {
                    // go to main screen
                    this.Close();
                }
                else
                {
                    label1.Visible = true;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Move(object sender, EventArgs e)
        {
            Program.location= this.Location;
            Program.size= this.Size;
        }

        /// <summary>
        /// check_password1() 
        /// select multiple rows using bind varibles
        /// </summary>
        private void check_password1()
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select username ,userpassword from users";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();

            bool flag = false;
            while (dr.Read())
            {
                string a1 = alphaBlendTextBox1.Text.ToString(), a2 = alphaBlendTextBox2.Text.ToString();
                string b1 = dr[0].ToString(), b2 = dr[1].ToString();

                if (a1 == b1 && a2 == b2)
                {
                    flag = true;
                    break;
                }
            }
            dr.Close();
            if (flag)
            {
                // modify this code to go to home page
                MessageBox.Show("Successful Login :" + Program.userType);
                ///<aaa>
                ///if(Program.userType)
                ///{
                ///     new Form%d*().show();
                ///     this.hide();
                ///}
                ///else 
                ///{
                ///     new Form%d*().show();
                ///     this.hide();
                /// 
                ///}
                ///</aaa>
            }
            else
            {
                label1.Visible = true;
                alphaBlendTextBox1.Text = "";
                alphaBlendTextBox2.Text = "";
                alphaBlendTextBox1.Focus();
            }
        }


//______________________________________________________________________________________

        /// <summary>
        /// check_password2()
        /// select single row with out using refcursor and ouput parametr of number dataType
        /// </summary>
        private bool check_password2()
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "pass";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("un", alphaBlendTextBox1.Text);
            cmd.Parameters.Add("up", alphaBlendTextBox2.Text);
            cmd.Parameters.Add("res", OracleDbType.Int32, ParameterDirection.Output);
            //cmd.Parameters.Add(new OracleParameter
            //{
            //    ParameterName = "ssn",
            //    Size = 14,
            //    Direction = ParameterDirection.ReturnValue,
            //    OracleDbType = OracleDbType.Char
            //});

            cmd.ExecuteNonQuery();
            if (cmd.Parameters["res"].Value.ToString() == "0")
            {
                return false;

            }
            else
            {
                string ssn=getSsn(alphaBlendTextBox1.Text.ToString(), alphaBlendTextBox2.Text.ToString());
                Program.currentuserssn = ssn;
                return true;

            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
        }
        private string getSsn(string name,string password)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select ssn from users where username=:un and userpassword=:up";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("un", name);
            cmd.Parameters.Add("up", password);

            OracleDataReader dr = cmd.ExecuteReader();
            try
            {
                dr.Read();
                 return dr[0].ToString();
            }
            catch
            {
                return "none";
            }
            return null;

        }
    }
}
