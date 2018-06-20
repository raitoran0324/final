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
using System.Windows.Forms;

namespace fishtank
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        int t = 0;
        Timer timer;

        public MainWindow()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_TickTock);
            
        }

        void timer_TickTock(object Sender, EventArgs e)
        {
            second.Text = t +"秒";
            t++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           timer.Start();
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
