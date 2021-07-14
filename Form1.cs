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
    public partial class Login : Form
    {
        SqlConnection Conn;
        public Login()
        {
            InitializeComponent();
            Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reliance\Desktop\Github\C-_Mini_Project-Cafe-Management\CustomerAdmin_Data.mdf;Integrated Security=True");
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
                string query = "select Mobile,Password from Customer where (" +
                    " Mobile = '" + username + "' or email='"+username+"') and (Password ='" + password + "');";
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
                Conn.Close();
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
                Login form1 = new Login();
                form1.Show();
            }
            else { Application.Exit(); }
            //MessageBox.Show("Are You sure you want to exit?","Exit", MessageBoxButtons.YesNo);
            //if(MessageBoxButtons)
            //Application.Exit();
        }

        private void llNewCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewCustomer frm = new NewCustomer();
            frm.Show();
        }

        private void llForgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_password frm = new Forgot_password();
            frm.Show();
        }

        private void llAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
            Admin_Login frm = new Admin_Login();
            this.Hide();
            frm.Show();
            
        }

        private void Show_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar=='*')
            {
                Hide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                Hide.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
