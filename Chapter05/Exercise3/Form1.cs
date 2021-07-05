using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }
        //フォームがロードされるタイミングで1回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
        }

        private void Button5_3_1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(c => c == ' ');
            TextBoxSpaceCount.Text = count.ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e) {
            TextBoxWordChange.Text = inputStrText.Text.Replace("big", "small");
        }

        private void Button5_3_3_Click(object sender, EventArgs e) {
            var items = inputStrText.Text.Split(' ');
            TextBoxWordCount.Text = items.Length.ToString();
        }

        private void Button5_3_4_Click(object sender, EventArgs e) {
            var items = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach (var item in items){
                TextBox5_3_4.Text += item + ' ';
            }
        }

        private void Button5_3_5_Click(object sender, EventArgs e) {
            var items = inputStrText.Text.Split(' ');
            var sb = new StringBuilder();
            foreach (var item in items) {
                sb.Append(item + ' ');
            }
            TextBox5_3_5.Text = sb.ToString();
        }
    }
}
