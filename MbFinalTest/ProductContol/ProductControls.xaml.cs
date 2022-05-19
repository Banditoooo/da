using MbFinalTest.Entity;
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

namespace MbFinalTest.ProductContol
{
    /// <summary>
    /// Логика взаимодействия для ProductControls.xaml
    /// </summary>
    public partial class ProductControls : UserControl
    {
        TradeEntities context;
        public Product product { get; set; }
        public Manufacture manufacture { get; set; }
        public ProductControls()
        {
            InitializeComponent();
            context = new TradeEntities();
            DataContext = this;
          
            
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (product.ProductImage != null)
            {
                Uri resourceUri = new Uri(Environment.CurrentDirectory+"/Images/" + product.ProductImage);
                Picture_Image.Source = new BitmapImage(resourceUri);
            }
            else
            {
                Picture_Image.Source = new BitmapImage(new Uri("pack://application:,,,/Image/picture.png"));
            }
        }
    }
}
