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
    public partial class UserControl1 : UserControl
    {
        private static UserControl1 _instance;
        public static UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }
        }
        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
