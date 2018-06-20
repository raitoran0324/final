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
        int s = 0;
        int m = 0;
        int h = 0;
        int f = 0;
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
            // 計時
            second.Text = s + "秒";
            minute.Text = m + "分";
            hour.Text = h + "時";
            if(s >= 59)
            {
                s = 0;
                m++;
                s++;
            }
            else
            {
                s++;
            }
           
            if(m >= 59)
            {
                m = 0;
                h++;
                m++;
            }

            // 過一小時
            if(h >= 1)
            {
                Full.Height = 250;
                Mid.Height = 200;
                Down.Height = 150;
            }

            // 過三十分鐘
            if(m >= 30)
            {
                Full.Height = 100;
                Mid.Height = 200;
                Down.Height = 150;
            }

            // 過十五分鐘以後
            if(m >= 15 && m <= 29)
            {
                Full.Height = 0;
                Mid.Height = 100;
                Down.Height = 150;
            }

            // 過十分鐘以後
            if(m >= 10 && m <= 14)
            {
                Full.Height = 0;
                Mid.Height = 0;
                Down.Height = 150;
            }

            // 一天
            if(h >= 24)
            {
                f++;
                Fish.Text = "0" + f.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 計時開始
            timer.Start();
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            //計時暫停
            timer.Stop();
        }
    }
}
