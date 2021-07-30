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
    public partial class UC_Bevarages : UserControl
    {
        SqlConnection con;
        public UC_Bevarages()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reliance\Desktop\Github\C-_Mini_Project-Cafe-Management\CafeMenu\Database1.mdf;Integrated Security=True");
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox41.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox41.Text + "', '50','" + numericUpDown41.Text + "',50*" + numericUpDown41.Text + ")";
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
                if (checkBox42.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox42.Text + "', '80','" + numericUpDown42.Text + "',80*" + numericUpDown42.Text + ")";
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
                if (checkBox43.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox43.Text + "', '40','" + numericUpDown43.Text + "',40*" + numericUpDown43.Text + ")";
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
                if (checkBox44.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox44.Text + "', '70','" + numericUpDown44.Text + "',70*" + numericUpDown44.Text + ")";
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
                if (checkBox45.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox45.Text + "', '90','" + numericUpDown45.Text + "',90*" + numericUpDown45.Text + ")";
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
                if (checkBox46.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                         "'" + checkBox46.Text + "', '80','" + numericUpDown46.Text + "',80*" + numericUpDown46.Text + ")";
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
                if (checkBox47.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox47.Text + "', '80','" + numericUpDown47.Text + "',80*" + numericUpDown47.Text + ")";

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
                if (checkBox48.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox48.Text + "', '120','" + numericUpDown48.Text + "',120*" + numericUpDown48.Text + ")";
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
                if (checkBox49.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox49.Text + "', '100','" + numericUpDown49.Text + "',100*" + numericUpDown49.Text + ")";
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
                if (checkBox50.Checked)
                {
                    string query = "INSERT INTO menudata (item,price,qty,total) values (" +
                        "'" + checkBox50.Text + "', '150','" + numericUpDown50.Text + "',150*" + numericUpDown50.Text + ")";
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
        //--------------------------------------------------------------------------------------------

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked)
            {
                numericUpDown41.Text = "1";
            }
            else
            {
                numericUpDown41.Text = "0";
            }
        }
        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox42.Checked)
                {
                    numericUpDown42.Text = "1";
                }
                else
                {
                    numericUpDown42.Text = "0";
                }
        }
        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox43.Checked)
                {
                    numericUpDown43.Text = "1";
                }
                else
                {
                    numericUpDown43.Text = "0";
                }
        }
        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox44.Checked)
                {
                    numericUpDown44.Text = "1";
                } 
                else
                {
                    numericUpDown44.Text = "0";
                }
        }
        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
                if (checkBox45.Checked)
                {
                    numericUpDown45.Text = "1";
                }
                else
                {
                   numericUpDown45.Text = "0";
                }
        }
        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked)
            {
                numericUpDown46.Text = "1";
            }
            else
            {
                numericUpDown46.Text = "0";
            }
        }
        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox47.Checked)
            {
                numericUpDown47.Text = "1";
            }
            else
            {
                numericUpDown47.Text = "0";
            }
        }
        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox48.Checked)
            {
                numericUpDown48.Text = "1";
            }
            else
            {
                numericUpDown48.Text = "0";
            }
        }
        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox49.Checked)
            {
                numericUpDown49.Text = "1";
            }
            else
            {
                numericUpDown49.Text = "0";
            }
        }
        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox50.Checked)
            {
                numericUpDown50.Text = "1";
            }
            else
            {
                numericUpDown50.Text = "0";
            }
        }
    }
}
