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
        Dictionary<string, string> dic = new Dictionary<string, string>()
        {
            {"1","あああ" },
            {"2","いいい" }
        };
        string filePath = @"C:\Users\infosys\Desktop\test.csv";
        private StreamWriter sw;

        public Form2()
        {
            InitializeComponent();
            sw = new StreamWriter(filePath, true, Encoding.GetEncoding("UTF-8"));
            DateTime dNow = System.DateTime.Now;
            DateTime dDate = dNow.Date;
            TimeSpan tTime = dNow.TimeOfDay;
        }
        
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lbNowTime.Text = DateTime.Now.ToString((("HH:mm")));
            timer1.Interval = 1000;
            timer1.Enabled = true;

            TextFieldParser parser = new TextFieldParser(@"C:\Users\infosys\Desktop\test.csv", Encoding.GetEncoding("Shift_JIS"));
            parser.TextFieldType = FieldType.Delimited;

            dgbtime.Rows.Clear();

            //while (!parser.EndOfData)
            //{
            //    string[] row = parser.ReadFields();
            //    dgbtime.Rows.Add(row);
            //}
        }

        private void btNew_Click(object sender, EventArgs e)
        {

        }

        private void btRegist_Click(object sender, EventArgs e)
        {
            //Regist(dgbtime);
        }

        private void Regist(string Name,int Number,DateTime A,DateTime B,DateTime C,DateTime D)
        {

        }

        private void btStartWork_Click(object sender, EventArgs e)
        {
   
            dgbtime.Rows.Add(Name,EmpNo);
            var result = "";
            dic.TryGetValue(tbEmpNo.Text, out result);
            dgbtime.Rows[0].Cells[0].Value = result;
            dgbtime.CurrentRow.Cells[2].Value = DateTime.Now.ToString("HH:mm");
            dgbtime.Rows[0].Cells[1].Value = tbEmpNo.Text;
            tbEmpNo.Text = "";
        }

        private void btEndWork_Click(object sender, EventArgs e)
        {
            dgbtime.Rows[0].Cells[5].Value = DateTime.Now.ToString("HH:mm");     
        }

        private void btStartRest_Click(object sender, EventArgs e)
        {
            dgbtime.Rows[0].Cells[3].Value = DateTime.Now.ToString("HH:mm");
        }

        private void btEndRest_Click(object sender, EventArgs e)
        {
            dgbtime.Rows[0].Cells[4].Value = DateTime.Now.ToString("HH:mm");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            lbNowTime.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}


