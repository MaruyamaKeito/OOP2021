using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int rand = 0;
        public MainWindow()
        {
            InitializeComponent();
            random(1, 26);
        }
        public void random(int min,int max)
        {
            Random r1 = new System.Random();
            rand = r1.Next(min, max);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = e.Source as Button;
            bt.Background = Brushes.Red;

            int select = int.Parse((string)bt.Content);

            if (rand == select)
            {
                tbAns.Text = "正解です";
            }
            else if(rand > select)
            {
                tbAns.Text = "小さいです";
            }
            else if(rand < select)
            {
                tbAns.Text = "大きいです";
            }
        }
    }
}
