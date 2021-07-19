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

namespace Exercise1 {
    public partial class btOpen : Form {
        public btOpen() {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdOpenfile.ShowDialog() == DialogResult.OK) {
                int count = 0;
                using(var reader = new StreamReader(ofdOpenfile.FileName,Encoding.GetEncoding("shift_jis"))) {
                    while (!reader.EndOfStream) { 
                        var line = reader.ReadLine();//1行読み込み
                        if (line.Contains(tbKeyWord.Text)) 
                            count++;
                        }
                    tbOutput.Text = "キーワード「" + tbKeyWord.Text + "」が含まれる行は、" + count.ToString() + "行です";
                    }
                }
            }
        
        private void btReadAllLines_Click(object sender, EventArgs e) {
            if (ofdOpenfile.ShowDialog() == DialogResult.OK) {
                int count = 0;
                var lines = File.ReadAllLines(ofdOpenfile.FileName, Encoding.GetEncoding("shift_jis"));
                foreach (var line in lines) {
                    if (line.Contains(tbKeyWord.Text)) {
                        count++;
                    }
                    tbOutput.Text = "キーワード「" + tbKeyWord.Text + "」が含まれる行は、" + count.ToString() + "行です";
                }
            }
        }
        
    }
}
