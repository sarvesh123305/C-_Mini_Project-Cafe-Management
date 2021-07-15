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
        SqlConnection Conn;
        public NewCustomer()
        {
            InitializeComponent();
            Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\githuy\C-_Mini_Project-Cafe-Management\CustomerAdmin_Data.mdf;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                Conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error");
            }
        }


    }
}
