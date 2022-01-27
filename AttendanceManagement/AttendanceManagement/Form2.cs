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
using System.Data.OleDb;

namespace AttendanceManagement
{
    public partial class Form2 : Form
    {
        string filePath = @"C:\Users\infosys\Desktop\test.csv";
        private StreamWriter sw;

        public Form2()
        {
            InitializeComponent();
            sw = new StreamWriter(filePath, true, Encoding.GetEncoding("UTF-8"));
        }
        
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextFieldParser parser = new TextFieldParser(@"C:\Users\infosys\Desktop\test.csv", Encoding.GetEncoding("Shift_JIS"));
            parser.TextFieldType = FieldType.Delimited;

            dgbtime.Rows.Clear();

            while (!parser.EndOfData)
            {
                string[] row = parser.ReadFields();
                dgbtime.Rows.Add(row);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {

        }

        private void btRegist_Click(object sender, EventArgs e)
        {

        }

        private void btStartWork_Click(object sender, EventArgs e)
        {
            dgbtime.CurrentRow.Cells[2].Value = DateTime.Now.ToString();
        }

        private void btEndWork_Click(object sender, EventArgs e)
        {
            dgbtime.CurrentRow.Cells[5].Value = DateTime.Now.ToString();
        }

        private void btStartRest_Click(object sender, EventArgs e)
        {
            dgbtime.CurrentRow.Cells[3].Value = DateTime.Now.ToString();
        }

        private void btEndRest_Click(object sender, EventArgs e)
        {
            dgbtime.CurrentRow.Cells[4].Value = DateTime.Now.ToString();
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
        public void Regist(DataGridView gridView)
        {
            var emp = new Employee
            {
                day = dtpDate.Value,
                EmpNumber = tbEmpNo.Text,
                Name = dgbtime.CurrentRow.Cells[0].Value.ToString(),
                StartWork = (DateTime)dgbtime.CurrentRow.Cells[2].Value,
                EndWork = (DateTime)dgbtime.CurrentRow.Cells[5].Value,
                StartRest = (DateTime)dgbtime.CurrentRow.Cells[3].Value,
                EndRest = (DateTime)dgbtime.CurrentRow.Cells[4].Value
            };
        }
    }
}
