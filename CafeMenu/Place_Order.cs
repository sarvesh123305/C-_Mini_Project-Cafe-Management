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
namespace CafeMenu
{
    public partial class Place_Order : Form
    {
        SqlConnection con;
        public static string NAME;
        public Place_Order(string name)
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=False");
            NAME = name;


        }

        private void Place_Order_Load(object sender, EventArgs e)
        {
            {
                label4.Visible = false;
                name.Visible = false;
                btn_del.Visible = false;

                display();
                string Query = "select sum(total) as labe1 from menudata;";
                SqlCommand Cmd = new SqlCommand(Query, con);
                try
                {

                    con.Open();
                    Cmd.ExecuteNonQuery();
                    DataTable td = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = Cmd;
                    sda.Fill(td);
                    if (td.Rows.Count > 0)
                    {
                        string result = Cmd.ExecuteScalar().ToString();
                        lbl_total.Text = result;
                    }
                    else if (td.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found", "No Data");
                    }
                    con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Error");
                }
            }
          


        }
            private void Place_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void display()
        {
            string query = "SELECT * FROM menudata";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Order_Order.DataSource = dt;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        static int no;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            try {
                Random rnd = new Random();
                no = rnd.Next(100, 500);
                string query = "insert into customer_data (TotalAmount,Name,Payment,OrderNo) values('"+lbl_total.Text+"','"+NAME+"','"+comboBox1.SelectedItem+"',"+no+")";
                SqlCommand cmd = new SqlCommand(query, con);
       
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                MessageBox.Show("Your Order has been placed Successfully!!\nYour Order Number is: "+no, "Success..");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                string query = "truncate table menudata";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu mm = new Menu(NAME);
            mm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label4.Visible = true;
            name.Visible = true;
            btn_del.Visible = true;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from menudata where id='"+name.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                
                cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Deleted Successfully", "Success");
                con.Close();


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            display();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            try
            {
                string query = "truncate table menudata";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                display();
                MessageBox.Show("All Items Cleared","Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();
            string nm = "";
            Menu mu = new Menu(nm);
            mu.Show();
        }
    }
}