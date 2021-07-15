using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_Mini_Project
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Admin" && txtPassword.Text=="Admin")//Static username and password for Admin
            {
                Admin_View frm = new Admin_View();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Please recheck your credentials", "Invalid data");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Admin_Login form1 = new Admin_Login();
                form1.Show();
            }
            else { Application.Exit(); }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
