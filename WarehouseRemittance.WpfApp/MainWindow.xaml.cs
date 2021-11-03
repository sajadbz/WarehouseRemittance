using System.Linq;
using System.Windows;
using WarehouseRemittance.Core.Services;
using WarehouseRemittance.WpfApp.ViewModels;

namespace WarehouseRemittance.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductService _productService = new ProductService();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GrdList.ItemsSource = _productService.GetAll().ToViewModel();
        }

        private void TxtSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSearch.Text))
                GrdList.ItemsSource = _productService.GetAll().ToViewModel();
            else
                GrdList.ItemsSource = _productService.GetAll(TxtSearch.Text).ToViewModel();            
        }
    }
}
