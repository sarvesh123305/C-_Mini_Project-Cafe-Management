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
    public partial class Forgot_password : Form
    {
        public Forgot_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\C-_Mini_Project-Cafe-Management;Integrated Security=True");
            //Sarvesh Anant Kulkarni
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
                string Query = "select Password from Customer where Mobile='" + textBox1.Text + "' and AadharNo='" + textBox2.Text +
                    "' and Bestfriend='" + textBox3.Text + "' and Nickname='" + textBox4.Text + "'";
                SqlCommand cmd = new SqlCommand(Query,Conn);
                cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(td);
                if(td.Rows.Count>0)
                {
                    this.Close();
                    string result = cmd.ExecuteScalar().ToString();
                    MessageBox.Show("Your Password is : "+result,"Success");
                }
                else if(td.Rows.Count == 0)
                {
                    MessageBox.Show("Sorry Your data is incorrect","Wrong Data");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error");
            }
        }

        private void Forgot_password_Load(object sender, EventArgs e)
        {

        }
    }
}
