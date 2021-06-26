using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Management_Mini_Project
{
    public partial class Form1 : Form
    {
        SqlConnection Conn;
        public Form1()
        {
            InitializeComponent();
             Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Sarvesh\Visual studio programs\repos\Cafe Management Mini Project\CustomerAdmin_Data.mdf;Integrated Security=True");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                ConnectionState state = Conn.State;
                if (state == ConnectionState.Open)
                {
                }
                else
                {
                    Conn.Open();
                }
                string query = "select Username,Password from Customer where Username = '" + username + "' and Password ='" + password + "';";
                SqlCommand cmd = new SqlCommand(query, Conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MessageBox.Show("Established");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Well Job");
                }
                else
                {
                    if (txtUsername.Text == "" && txtPassword.Text == "")
                    {
                        MessageBox.Show("Please enter all the fields", "Error");
                    }
                    else if (txtUsername.Text == "")
                    {
                        MessageBox.Show("Please Enter Username");
                    }
                    else if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Please Enter Password", "Error");
                    }
                    else
                    {
                        MessageBox.Show("Please check your Username or Password", "Invalid Details");
                    }
                }
            }
            catch (Exception Ex)
            {
               
                MessageBox.Show(Ex.Message,"Error");
            }
            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else { Application.Exit(); }
            //MessageBox.Show("Are You sure you want to exit?","Exit", MessageBoxButtons.YesNo);
            //if(MessageBoxButtons)
            //Application.Exit();
        }
    }
}
