using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RestTextboxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else func(control.Controls);
            };
            func(Controls);
        }

        private void RestCheckboxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked=false;
                    else func(control.Controls);
            };
            func(Controls);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            RestTextboxes();
            RestCheckboxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_category.Text == "Chinese")
                pnl_chinese.Visible = true;
            if (cmb_category.Text == "Italian")
                pnl_italian.Visible = true;

        }
    }
}
