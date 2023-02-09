using AppBeatyShopUser3.Actions;
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

namespace AppBeatyShopUser3.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageSignIn.xaml
    /// </summary>
    public partial class PageSignIn : Page
    {
        public PageSignIn()
        {
            InitializeComponent();
        }

        private void JoinAdmin_Click(object sender, RoutedEventArgs e)
        {
            ClassNavigate.FrmNav.Navigate(new PageAdminLog());
        }

        private void JoinUser_Click(object sender, RoutedEventArgs e)
        {
            ClassNavigate.FrmNav.Navigate(new PageUser());
        }
    }
}
