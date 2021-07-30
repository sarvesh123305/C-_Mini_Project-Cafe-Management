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
    public partial class UC_Southindian : UserControl
    {
        SqlConnection con;
        public UC_Southindian()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False");

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox16.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox16.Text + "', '60','" + numericUpDown16.Text + "',60*" + numericUpDown16.Text + ")";
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
                if (checkBox17.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox17.Text + "', '70','" + numericUpDown17.Text + "',70*" + numericUpDown17.Text + ")";
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
                if (checkBox18.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox18.Text + "', '80','" + numericUpDown18.Text + "',80*" + numericUpDown18.Text + ")";
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
                if (checkBox19.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox19.Text + "', '80','" + numericUpDown19.Text + "',80*" + numericUpDown19.Text + ")";
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
                if (checkBox20.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox20.Text + "', '60','" + numericUpDown20.Text + "',60*" + numericUpDown20.Text + ")";
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
                if (checkBox21.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox21.Text + "', '70','" + numericUpDown21.Text + "',70*" + numericUpDown21.Text + ")";
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
                if (checkBox22.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox22.Text + "', '60','" + numericUpDown22.Text + "',60*" + numericUpDown22.Text + ")";

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

                if (checkBox23.Checked)
                {

                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox23.Text + "', '140','" + numericUpDown23.Text + "',140*" + numericUpDown23.Text + ")";

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

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox16.Checked)
            {
                numericUpDown16.Text = "1";
            }
            else
            {
                numericUpDown16.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox17.Checked)
            {
                numericUpDown17.Text = "1";
            }
            else
            {
                numericUpDown17.Text = "0";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox18.Checked)
            {
                numericUpDown18.Text = "1";
            }
            else
            {
                numericUpDown18.Text = "0";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox19.Checked)
            {
                numericUpDown19.Text = "1";
            }
            else
            {
                numericUpDown19.Text = "0";
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox20.Checked)
            {
                numericUpDown20.Text = "1";
            }
            else
            {
                numericUpDown20.Text = "0";
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox21.Checked)
            {
                numericUpDown21.Text = "1";
            }
            else
            {
                numericUpDown21.Text = "0";
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox22.Checked)
            {
                numericUpDown22.Text = "1";
            }
            else
            {
                numericUpDown22.Text = "0";
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox23.Checked)
            {
                numericUpDown23.Text = "1";
            }
            else
            {
                numericUpDown23.Text = "0";
            }
        }
    }
}
