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
    public partial class UC_Italian : UserControl
    {
        SqlConnection con;
        public UC_Italian()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reliance\Desktop\Github\C-_Mini_Project-Cafe-Management\CafeMenu\Database1.mdf;Integrated Security=True");

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox8.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox8.Text + "', '60','" + numericUpDown8.Text + "',60*" + numericUpDown8.Text + ")";
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
                if (checkBox9.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox9.Text + "', '80','" + numericUpDown9.Text + "',80*" + numericUpDown9.Text + ")";
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
                if (checkBox10.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox10.Text + "', '100','" + numericUpDown10.Text + "',100*" + numericUpDown10.Text + ")";
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
                if (checkBox11.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox11.Text + "', '140','" + numericUpDown11.Text + "',140*" + numericUpDown11.Text + ")";
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
                if (checkBox12.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox12.Text + "', '75','" + numericUpDown12.Text + "',75*" + numericUpDown12.Text + ")";
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
                if (checkBox13.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox13.Text + "', '90','" + numericUpDown13.Text + "',90*" + numericUpDown13.Text + ")";
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
                if (checkBox14.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox14.Text + "', '70','" + numericUpDown14.Text + "',70*" + numericUpDown14.Text + ")";

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

                if (checkBox15.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox15.Text + "', '80','" + numericUpDown15.Text + "',80*" + numericUpDown15.Text + ")";

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

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox8.Checked)
            {
                numericUpDown8.Text = "1";
            }
            else
            {
                numericUpDown8.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox9.Checked)
            {
                numericUpDown9.Text = "1";
            }
            else
            {
                numericUpDown9.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox10.Checked)
            {
                numericUpDown10.Text = "1";
            }
            else
            {
                numericUpDown10.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox11.Checked)
            {
                numericUpDown11.Text = "1";
            }
            else
            {
                numericUpDown11.Text = "0";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox12.Checked)
            {
                numericUpDown12.Text = "1";
            }
            else
            {
                numericUpDown12.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox13.Checked)
            {
                numericUpDown13.Text = "1";
            }
            else
            {
                numericUpDown13.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox14.Checked)
            {
                numericUpDown14.Text = "1";
            }
            else
            {
                numericUpDown14.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox15.Checked)
            {
                numericUpDown15.Text = "1";
            }
            else
            {
                numericUpDown15.Text = "0";
            }
        }
    }
}
