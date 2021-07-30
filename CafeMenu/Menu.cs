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
    public partial class Menu : Form
    {
        SqlConnection con;
        public static string NAME;
        public Menu(string name)
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Reliance\Desktop\Github\C-_Mini_Project-Cafe-Management\CafeMenu\Database1.mdf;Integrated Security=True");
            NAME = name;
            
        }
       public string id
        {
            get{ return NAME; }
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChinese_Click(object sender, EventArgs e)
        {
            uC_Chinese1.Visible = true;
            uC_Chinese1.BringToFront();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            uC_welcome1.ID = id;
            uC_welcome1.Visible = true;
            uC_Chinese1.Visible = false;
            uC_Italian1.Visible = false;
            uC_Southindian1.Visible = false;
            uC_Bevarages1.Visible = false;
           

        }

        private void btnItalian_Click(object sender, EventArgs e)
        {
            uC_Italian1.Visible = true;
            uC_Italian1.BringToFront();

        }

        private void btnSouthindian_Click(object sender, EventArgs e)
        {
            uC_Southindian1.Visible = true;
            uC_Southindian1.BringToFront();
        }

        private void btnBevarages_Click(object sender, EventArgs e)
        {
            uC_Bevarages1.Visible = true;
            uC_Bevarages1.BringToFront();
        }

        public void btnAddtocart_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select count(id) from menudata";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                cmd.ExecuteNonQuery();
                sda.Fill(dt);
               

                if (dt.Rows.Count > 0)
                {
                    string result = cmd.ExecuteScalar().ToString();
                    
                    if (result == "0")
                    {
                        MessageBox.Show("No item(s) Selected..", "Empty Cart!");
                    }
                    else
                    {

                        this.Hide();
                        Place_Order frm = new Place_Order(NAME);
                        frm.Show();
                    }
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No item(s) Selected..", "Empty Cart!");
                }
               
                
                con.Close();
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
