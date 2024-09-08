using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tianyi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button.Content = "可爱";
            Random random = new Random();

            button.Height = 47;
            button.Width = 97;
            button.FontSize = 30;
            button.HorizontalAlignment = HorizontalAlignment.Left;
            button.VerticalAlignment = VerticalAlignment.Top;
            TranslateTransform translateTransform = new TranslateTransform();
            translateTransform.X = random.Next(40)+160;
            translateTransform.Y = random.Next(40)+260;
            button.RenderTransform = translateTransform;
            button.Click += Button_Click_1;
            ((Grid)this.FindName("Grid")).Children.Add(button);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            PopupWindow popup = new PopupWindow();
            popup.Owner = this;
            //popup.PopupTextBlock.Text = "天依真的可爱";
            popup.ShowDialog();
            this.IsEnabled = true;
        }
    }
}