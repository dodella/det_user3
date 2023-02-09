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
    /// Логика взаимодействия для PageAdminLog.xaml
    /// </summary>
    public partial class PageAdminLog : Page
    {
        public PageAdminLog()
        {
            InitializeComponent();
        }

        private void BtnLogAdmin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PassAdm.Password == "0000")
                {
                    MessageBox.Show("Вы вошли!");
                    ClassNavigate.FrmNav.Navigate(new PageAdmin());
                }
                else
                {
                    MessageBox.Show("Вы ошиблись(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
