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
    public partial class Admin_View : Form
    {
        SqlConnection Conn;
        public Admin_View()
        {
            InitializeComponent();
            Conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reliance\Desktop\Github\C-_Mini_Project-Cafe-Management\CafeMenu\Database1.mdf;Integrated Security=True");

        }

        private void Admin_View_Load(object sender, EventArgs e)
        {
            try
            {
                Conn.Open();
                string Query = "select * from customer_data";

                SqlCommand cmd = new SqlCommand(Query, Conn);
                cmd.ExecuteNonQuery();
                DataTable td = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(td);
                if (td.Rows.Count > 0)
                {
                    Datagrid1.DataSource = td;
                }
                else
                {
                   
                    MessageBox.Show("Sorry! No data Found", "No data");
                }

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error");
            }
        }

        private void Admin_View_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Login frm = new Login();
            frm.Show();
        }

        private void Datagrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
