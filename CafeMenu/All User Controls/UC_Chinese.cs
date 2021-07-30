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
namespace CafeMenu.All_User_Controls
{
    public partial class UC_Chinese : UserControl
    {
        SqlConnection con;
        public UC_Chinese()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reliance\Desktop\Github\C-_Mini_Project-Cafe-Management\CafeMenu\Database1.mdf;Integrated Security=True");
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'"+checkBox1.Text+"', '50','" + numericUpDown1.Text + "',50*"+ numericUpDown1.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                if (checkBox3.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'"+checkBox3.Text+"', '80','" + numericUpDown2.Text + "',80*"+numericUpDown2.Text+")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                if (checkBox2.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox2.Text + "', '90','" + numericUpDown3.Text + "',90*"+numericUpDown3.Text+")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                if (checkBox5.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox5.Text + "', '110','" + numericUpDown4.Text + "',110*" + numericUpDown4.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                if (checkBox4.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox4.Text + "', '60','" + numericUpDown7.Text + "',60*" + numericUpDown7.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                if (checkBox6.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox6.Text + "', '70','" + numericUpDown6.Text + "',70*" + numericUpDown6.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                if (checkBox7.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox7.Text + "', '90','" + numericUpDown5.Text + "',90*" + numericUpDown5.Text + ")";

                    SqlCommand cmd = new SqlCommand(query, con);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                MessageBox.Show("Added to cart", "Success..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Text = "1";
            }
            else
            {
                numericUpDown1.Text = "0";
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                numericUpDown2.Text = "1";
            }
            else
            {
                numericUpDown2.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDown3.Text = "1";
            }
            else
            {
                numericUpDown3.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                numericUpDown4.Text = "1";
            }
            else
            {
                numericUpDown4.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                numericUpDown7.Text = "1";
            }
            else
            {
                numericUpDown7.Text = "0";
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                numericUpDown6.Text = "1";
            }
            else
            {
                numericUpDown6.Text = "0";
            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                numericUpDown5.Text = "1";
            }
            else
            {
                numericUpDown5.Text = "0";
            }
        }
    }
}
