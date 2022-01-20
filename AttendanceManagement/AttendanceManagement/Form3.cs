using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btBack2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HourlyWage_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
            using (StreamWriter writer = new StreamWriter("test.csv", true))
            {

            }
        }

        private void HourlyWage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
