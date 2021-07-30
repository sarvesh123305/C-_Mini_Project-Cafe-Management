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
    public partial class NewCustomer : Form
    {
        SqlConnection Conn;
        public NewCustomer()
        {
            InitializeComponent();
            Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False");
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
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
                    textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                {
                    MessageBox.Show("Please enter all the fields", "Incomplete Data");
                }
                else if (textBox6.Text != textBox7.Text)
                {
                    MessageBox.Show("Passwords dont match", "Invalid password");
                }
                else
                {

                    try
                    {
                        string to, from, pass, msgbody;
                        MailMessage msg = new MailMessage();
                        to = textBox4.Text;
                        from = "gpevents20121@gmail.com";
                        pass = "dontchangepass";                     
                        msgbody = "Congrats "+textBox1.Text+"!! You Have Successfully Registered yourself For ASA's Cafe\nEnjoy Our Service..\nFor any Queries Contact: gpevents20121@gmail.com (+91-9876543210)";
                        msg.To.Add(to);
                        msg.From = new MailAddress(from);
                        msg.Body = msgbody;
                        msg.Subject = "Your Profile Created - ASA's Cafe";
                        msg.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        smtp.Send(msg);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message+textBox4.Text, "Error");
                    }
                }
              string Query = "insert into Customer (Password,Name,Mobile,Address,Email,AadharNo)" +
                " values ('" + textBox6.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"
                + textBox5.Text + "');";
                SqlCommand cmd = new SqlCommand(Query, Conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile Created Successfully! \nPlease CheckOut Your E-Mail..", "Success");
                this.Close();

                Conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error");
            }
        }


    }
}
