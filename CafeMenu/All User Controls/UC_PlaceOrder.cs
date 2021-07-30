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
    public partial class UC_PlaceOrder : UserControl
    {
        SqlConnection con;
        public UC_PlaceOrder()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\Users\Admin\Documents\Database1.mdf;Integrated Security = True; Connect Timeout = 30; User Instance = False");

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM menudata";
            //SqlCommand cmd = new SqlCommand(query, con);
            //try
            //{
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter sda = new SqlDataAdapter();
            //    sda.SelectCommand = cmd;
            //    sda.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        DG_place.DataSource = dt;
            //    }
            //    con.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
           // DG_place.Show();
      }
    }
}
