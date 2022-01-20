using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AttendanceManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextFieldParser parser = new TextFieldParser(@"C:\Users\infosys\Desktop\test.csv", Encoding.GetEncoding("Shift_JIS"));
            parser.TextFieldType = FieldType.Delimited;

            dataGridView1.Rows.Clear();

            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields();
                dataGridView1.Rows.Add(row);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {

        }

        private void btRegist_Click(object sender, EventArgs e)
        {

        }

        private void btStartWork_Click(object sender, EventArgs e)
        {

        }

        private void btEndWork_Click(object sender, EventArgs e)
        {

        }

        private void btStartRest_Click(object sender, EventArgs e)
        {

        }

        private void btEndRest_Click(object sender, EventArgs e)
        {

        }

        private void tbEmpNo_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
            using (StreamWriter writer = new StreamWriter("test.csv", true))
            {

            }
        }
    }
}
