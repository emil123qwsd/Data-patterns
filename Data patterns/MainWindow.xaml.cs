using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Data_patterns
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Виноград",
                ProdPrice = 300,
                ProdImage = "Data/Виноград.jpg",
                ProductCategorys = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Груши",
                ProdPrice = 250,
                ProdImage = "Data/Груши.jpg",
                ProductCategorys = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Мандарины",
                ProdPrice = 300,
                ProdImage = "Data/Мандарины.jpg",
                ProductCategorys = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Холодильник",
                ProdPrice = 80000,
                ProdImage = "Data/Холодильник.jpg",
                ProductCategorys = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Телевизор",
                ProdPrice = 60000,
                ProdImage = "Data/Телевизор.jpg",
                ProductCategorys = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Стиральная машина",
                ProdPrice = 45000,
                ProdImage = "Data/Стиральная машина.jpg",
                ProductCategorys = ProductCategorys.Food
            });
            listBox.ItemsSource = products;
        }
    }
}
