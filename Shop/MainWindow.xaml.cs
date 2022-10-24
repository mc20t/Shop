using System.Windows;

namespace Shop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Content = new Pages.MainPage();
        }

    }
}
