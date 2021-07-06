using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                        (control as CheckBox).Checked = false;
                    else func(control.Controls);
            };
            func(Controls);
        }

        private void ResetDataGridView()
        {
            dataGridView1.Rows.Clear(); 
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            RestTextboxes();
            RestCheckboxes();
            ResetDataGridView();
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmb_category.SelectedItem.ToString() == "Chinese")
            {
               if(!panel3.Controls.Contains(UserControl2.Instance))
                {
                    panel3.Controls.Add(UserControl2.Instance);
                    UserControl2.Instance.BringToFront();
                }
            }
            if (cmb_category.SelectedItem.ToString() == "Italian")
            {
                pnl_italian.Visible = true;
            }
            if (cmb_category.SelectedItem.ToString() == "South Indian")
            {
                pnl_southindian.Visible = true;
            }
            if (cmb_category.SelectedItem.ToString() == "Bevarages")
            {
                pnl_bevarages.Visible = true;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        string name;
        int price;
        int tot;
        private void btn_placeorder_Click(object sender, EventArgs e)
        {
            //=====================CHINESE======================//
            if(checkBox1.Checked)
            {

                name = "Veg Manchurian";
                int qty = int.Parse(numericUpDown1.Value.ToString());
                price = 80;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
           if (checkBox3.Checked)
            {

                name = "Chicken Manchurian";
                int qty = int.Parse(numericUpDown2.Value.ToString());
                price = 100;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox2.Checked)
            {

                name = "Veg Schezwan Noodles";
                int qty = int.Parse(numericUpDown3.Value.ToString());
                price = 90;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox5.Checked)
            {

                name = "Chicken Schezwan Noodles";
                int qty = int.Parse(numericUpDown4.Value.ToString());
                price = 120;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox4.Checked)
            {

                name = "Veg Soup";
                int qty = int.Parse(numericUpDown7.Value.ToString());
                price = 60;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox6.Checked)
            {

                name = "Veg Manchow Soup";
                int qty = int.Parse(numericUpDown6.Value.ToString());
                price = 75;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox7.Checked)
            {

                name = "Chicken Manchow Soup";
                int qty = int.Parse(numericUpDown5.Value.ToString());
                price = 90;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }

        //===================ITALIAN======================================
            if (checkBox14.Checked)
            {

                name = "Veg Burger";
                int qty = int.Parse(numericUpDown14.Value.ToString());
                price = 70;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox12.Checked)
            {

                name = "Chicken Burger";
                int qty = int.Parse(numericUpDown13.Value.ToString());
                price = 90;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox13.Checked)
            {

                name = "Veg Pizza";
                int qty = int.Parse(numericUpDown12.Value.ToString());
                price = 120;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox10.Checked)
            {

                name = "Chicken Pizza";
                int qty = int.Parse(numericUpDown11.Value.ToString());
                price = 160;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox11.Checked)
            {

                name = "Veg Pasta";
                int qty = int.Parse(numericUpDown8.Value.ToString());
                price = 90;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox9.Checked)
            {

                name = "Chicken Pasta";
                int qty = int.Parse(numericUpDown9.Value.ToString());
                price = 120;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox8.Checked)
            {

                name = "Salted Fries";
                int qty = int.Parse(numericUpDown10.Value.ToString());
                price = 65;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox15.Checked)
            {

                name = "Peri-Peri Fries";
                int qty = int.Parse(numericUpDown23.Value.ToString());
                price = 75;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }

            //===============SOUTH_INDIAN=======================================
            if (checkBox23.Checked)
            {

                name = "Masala Dosa";
                int qty = int.Parse(numericUpDown21.Value.ToString());
                price = 70;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox21.Checked)
            {

                name = "Loni Dosa";
                int qty = int.Parse(numericUpDown20.Value.ToString());
                price = 75;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox22.Checked)
            {

                name = "Set Dosa";
                int qty = int.Parse(numericUpDown19.Value.ToString());
                price = 80;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox19.Checked)
            {

                name = "Mysore Dosa";
                int qty = int.Parse(numericUpDown18.Value.ToString());
                price = 80;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox20.Checked)
            {

                name = "Idli";
                int qty = int.Parse(numericUpDown22.Value.ToString());
                price = 60;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox18.Checked)
            {

                name = "Idli Wada";
                int qty = int.Parse(numericUpDown15.Value.ToString());
                price = 75;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox17.Checked)
            {

                name = "Upma";
                int qty = int.Parse(numericUpDown16.Value.ToString());
                price = 50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox16.Checked)
            {

                name = "Dakshin Spl. Thali";
                int qty = int.Parse(numericUpDown17.Value.ToString());
                price = 150;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }

        //=================Bevarages=====================================
            if (checkBox31.Checked)
            {

                name = "Hot Coffee";
                int qty = int.Parse(numericUpDown31.Value.ToString());
                price = 50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox29.Checked)
            {

                name = "Cold Coffee";
                int qty = int.Parse(numericUpDown30.Value.ToString());
                price = 60;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox32.Checked)
            {

                name = "Black Coffee";
                int qty = int.Parse(numericUpDown29.Value.ToString());
                price = 40;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox33.Checked)
            {

                name = "Lemonade";
                int qty = int.Parse(numericUpDown28.Value.ToString());
                price = 50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox30.Checked)
            {

                name = "Choco Cad'B";
                int qty = int.Parse(numericUpDown24.Value.ToString());
                price = 75;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox27.Checked)
            {

                name = "Vanilla Cad'B";
                int qty = int.Parse(numericUpDown25.Value.ToString());
                price = 80;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox28.Checked)
            {

                name = "Hot Chocolate";
                int qty = int.Parse(numericUpDown26.Value.ToString());
                price = 70;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox26.Checked)
            {

                name = "Strawberry Cocktail";
                int qty = int.Parse(numericUpDown27.Value.ToString());
                price = 100;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox25.Checked)
            {

                name = "Spl. Mojito";
                int qty = int.Parse(numericUpDown33.Value.ToString());
                price = 90;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (checkBox24.Checked)
            {

                name = "Chocolate Brownie";
                int qty = int.Parse(numericUpDown32.Value.ToString());
                price = 110;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
        }
    }
}
