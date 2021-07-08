using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {

        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            //lbTimerDisp.Text = "00:00:00.00";
        }

        private void startbt_Click(object sender, EventArgs e) {
            var tm = new Timer();
            sw.Start();
            tm.Tick += Tm_Tick;
            tm.Interval = 1;
            tm.Start();
        }

        private void Tm_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void stopbt_Click(object sender, EventArgs e) {
            sw.Stop();
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }

        private void resetbt_Click(object sender, EventArgs e) {
            sw.Reset();
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            laplb.Items.Clear();
        }

        private void lapbt_Click(object sender, EventArgs e) {
            laplb.Items.Add(sw.Elapsed.ToString(@"hh\:mm\:ss\.ff"));
            //laplb.Items.Insert(0, lbTimerDisp.Text);
        }
    }
}
