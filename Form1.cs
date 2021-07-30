using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cafe_Management_Mini_Project
{
    public partial class Login : Form
    {
        SqlConnection Conn;
        public Login()
        {
            InitializeComponent();
            Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reliance\Desktop\Github\C-_Mini_Project-Cafe-Management\CafeMenu\Database1.mdf;Integrated Security=True");
        }
        public static string name;
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Login form1 = new Login();
                form1.Show();
            }
            else 
            { 
                this.Close();
            }
            
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

        private void Login_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            if (txtPassword.PasswordChar == '*')
            {
                button2.BringToFront();
                txtPassword.PasswordChar= '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
            if (txtPassword.PasswordChar == '\0')
            {
                button1.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("For any Queries Contact Us\nEmail : gpevents20121@gmail.com\n\nOur team will contact you within 24-48 working hours please be patient.....Thanks for cooperation!", "Help");
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string query = "truncate table menudata";
                    SqlCommand cmd = new SqlCommand(query, Conn);

                    Conn.Open();
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string qry = "select Name from Customer where Mobile='" + txtUsername.Text + "' or Email='" + txtUsername.Text + "'";
            SqlCommand cmdd = new SqlCommand(qry, Conn);

            Conn.Open();
            DataTable dat = new DataTable();
            SqlDataAdapter sad = new SqlDataAdapter(cmdd);
            sad.SelectCommand = cmdd;
            sad.Fill(dat);
            if (dat.Rows.Count > 0)
            {
                string result = cmdd.ExecuteScalar().ToString();
                name = result;
            }
            cmdd.ExecuteNonQuery();
            Conn.Close();

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
                    " Mobile = '" + username + "' or email='" + username + "') and (Password ='" + password + "');";
                SqlCommand cmd = new SqlCommand(query, Conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    CafeMenu.Menu mn = new CafeMenu.Menu(name);
                    mn.Show();
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
            catch (SqlException Ex)
            {
                if (Ex.Number == 2627)
                {
                    MessageBox.Show("Please enter unique Email-id or Mobile number", "Error");
                }
                MessageBox.Show(Ex.Message, "Error");
            }
        }
    }
}
