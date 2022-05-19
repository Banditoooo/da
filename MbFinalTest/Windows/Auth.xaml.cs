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
using System.Windows.Shapes;

namespace MbFinalTest.Windows
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        TradeEntities context;
        
        public Auth()
        {
            InitializeComponent();
            context = new TradeEntities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = context.User.FirstOrDefault(p => p.UserLogin == login_textbox.Text & p.UserPassword == Password_textbox.Text);
            if(user!=null)
            {
                MessageBox.Show("daaaa");
                if(user.UserRole==1)
                {
                    temp.UserNow = "Клиент";
                }
                if (user.UserRole == 2)
                {
                    temp.UserNow = "Менеджер";
                }
                if (user.UserRole == 3)
                {
                    temp.UserNow = "Администратор";
                }
                Window window = new MainWindow();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("неа");
            }    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            temp.UserNow = "Гость";
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
