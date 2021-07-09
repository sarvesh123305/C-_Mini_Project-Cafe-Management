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
                    textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" )
                {
                    MessageBox.Show("Please enter all the fields", "Incomplete Data");
                }
                else
                { 
                string Query = "insert into Customer (Password,Name,Mobile,Address,Email,AadharNo,Nickname,Bestfriend)" +
                    " values ('"+textBox6.Text+"','"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"
                    +textBox5.Text+"','"+textBox7.Text+"','"+textBox8.Text+"');";
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
    }
}
