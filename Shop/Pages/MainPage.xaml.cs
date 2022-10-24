using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Shop.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClientBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientPage());
        }

        private void TagBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TagPage());
        }

        private void AdminBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void RegionBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegionPage());
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductPage());
        }

        private void CategoryBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CategoryPage());
        }

        private void ManufacturerBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ManufacturerPage());
        }

        private void UnitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UnitPage());
        }

        private void ProductSaleBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductSalePage());
        }

        private void PurchaseBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PurchasePage());
        }

        private void ClAdmRegBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClAdmRegPage());
        }

        private void TagOfCl_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TagOfClientPage());
        }

        private void ManufProd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ManufacturerProductPage());
        }

        private void Money_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MoneyPage());
        }
    }
}
