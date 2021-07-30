using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMenu
{
    public partial class UC_welcome : UserControl
    {
        public UC_welcome()
        {
            InitializeComponent();
          
        }
        public string ID
        {
            set { label3.Text = value; }
        }
    }
}
