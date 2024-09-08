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
    /// Agree.xaml 的交互逻辑
    /// </summary>
    public partial class Agree : Window
    {
        public Agree()
        {
            InitializeComponent();
            double width = System.Windows.SystemParameters.WorkArea.Width;
            double heigth = System.Windows.SystemParameters.WorkArea.Height;
            double winWidth = 400;
            double winHeight = 100;
            Left = (width - winWidth) / 2;
            Top = (heigth - winHeight) / 2;
        }
    }
}
