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
using System.Net;
using System.Net.Mail;

namespace Cafe_Management_Mini_Project
{
    public partial class Forgot_password : Form
    {
        SqlConnection Conn;
        public Forgot_password()
        {
            InitializeComponent();
            Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reliance\Desktop\Github\C-_Mini_Project-Cafe-Management\CustomerAdmin_Data.mdf;Integrated Security=True");
        }
        static int num;
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
                string Query = "select Password from Customer where Mobile='" + textBox1.Text +
                    "' and Password = '" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(Query,Conn);
                cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(td);
                if(td.Rows.Count>0)
                {
                   
                    string result = cmd.ExecuteScalar().ToString();
                    MessageBox.Show("Your Password is : "+result,"Success");
                    this.Close();
                }
                else if(td.Rows.Count == 0)
                {
                    MessageBox.Show("Sorry Your data is incorrect","Wrong Data");
                }
                Conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                Random rnd = new Random();
                num = rnd.Next(100000, 999999);//Generates random number between specified range
        
                try
                {

                    string to, from, pass, msgbody;
                    MailMessage msg = new MailMessage();
                    to = textBox1.Text;
                    from = "gpevents20121@gmail.com";
                    pass = "howyoudoin";
                    msgbody = "Your OTP is : " + num;
                    msg.To.Add(to);
                    msg.From = new MailAddress(from);
                    msg.Body = msgbody;
                    msg.Subject = "OTP for password";
                    msg.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    smtp.Send(msg);
                    DialogResult code = MessageBox.Show("Email sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (code == DialogResult.OK)
                    {

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

                if (num.ToString() == textBox2.Text)
                {
                    
                    string Query = "select Password from Customer where Email='" + textBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(Query, Conn);
                    cmd.ExecuteNonQuery();
                    DataTable td = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(td);
                    if (td.Rows.Count > 0)
                    {

                        string result = cmd.ExecuteScalar().ToString();
                        MessageBox.Show("Your Password is : " + result, "Success");
                    }
                    else if (td.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid Username", "Wrong Data");
                    }
                }
                else
                {
                    MessageBox.Show("Please recheck your OTP", "Failure");
                }
                Conn.Close();
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
