using MbFinalTest.Entity;
using MbFinalTest.ProductContol;
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

namespace MbFinalTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TradeEntities context;
        List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            context = new TradeEntities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            User_label.Content = temp.UserNow;
            products = context.Product.ToList();
           
            foreach(Product product in products)
            {
                product_list.Items.Add(new ProductControls() {product=product });
            }
        }
    }
}
