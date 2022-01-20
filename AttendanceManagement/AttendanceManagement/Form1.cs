using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagement
{
    public partial class Form1 : Form
    {

        private static Form2 _instance;
        private static Form3 _instance2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            Instance.Show();
        }

        private void btManage_Click(object sender, EventArgs e)
        {
            Instance2.Show();
        }
        public static Form2 Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new Form2();
                }
                return _instance;
            }
        }
        public static Form3 Instance2
        {
            get
            {
                if (_instance2 == null || _instance2.IsDisposed)
                {
                    _instance2 = new Form3();
                }
                return _instance2;
            }
        }

    }
}
