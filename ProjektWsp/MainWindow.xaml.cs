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

namespace ProjektWsp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock block = new TextBlock();
            block.Text = "Test";
            block.HorizontalAlignment= HorizontalAlignment.Center;
            block.VerticalAlignment= VerticalAlignment.Center;
            block.FontSize = 20;
            block.Foreground = Brushes.Black;

            this.Content = block;
            this.RegisterName("TextBlock1", block);
        }
    }
}