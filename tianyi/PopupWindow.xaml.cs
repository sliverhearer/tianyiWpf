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
using System.Windows.Shapes;

namespace tianyi
{
    /// <summary>
    /// PopupWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PopupWindow : Window
    {
        public PopupWindow()
        {
            InitializeComponent();
            double screenWidth = System.Windows.SystemParameters.WorkArea.Width;
            double screenHeight = System.Windows.SystemParameters.WorkArea.Height;

            // 假设窗口宽度为 400，高度为 300
            double windowWidth = 200;
            double windowHeight = 100;

            // 计算窗口位置
            Left = (screenWidth - windowWidth) / 2;
            Top = (screenHeight - windowHeight) / 2;
            var uri = new Uri("C:\\Users\\jkuil\\source\\repos\\tianyi\\tianyi\\img\\tianyi .jpg");
            var bitmapImage = new BitmapImage(uri);
            Background = new ImageBrush(bitmapImage);
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Agree agree = new Agree();
            agree.Show();
        }
    }
}
