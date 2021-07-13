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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Sarvesh\Visual studio programs\repos\Cafe Management Mini Project\CustomerAdmin_Data.mdf;Integrated Security=True");
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
                if(textBox1.Text=="" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                    textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" )
                {
                    MessageBox.Show("Please enter all the fields", "Incomplete Data");
                }
                else if(textBox6.Text!=textBox7.Text)
                {
                    MessageBox.Show("Passwords dont match", "Invalid password");
                }
                else
                { 
                string Query = "insert into Customer (Password,Name,Mobile,Address,Email,AadharNo)" +
                    " values ('"+textBox6.Text+"','"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"
                    +textBox5.Text+"');";
                    SqlCommand cmd = new SqlCommand(Query, Conn);
                    cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully.Your Username is your Mobile Number", "Success");
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
