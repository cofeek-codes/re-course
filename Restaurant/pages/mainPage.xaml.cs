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

namespace Restaurant.pages
{
    /// <summary>
    /// Логика взаимодействия для mainPage.xaml
    /// </summary>
    public partial class mainPage : Page
    {
        public mainPage(int roleId)
        {
            InitializeComponent();
            if (roleId == 2)
            {
                btnReports.Visibility = Visibility.Hidden;
                btnEmpoloyee.Visibility = Visibility.Hidden;
            }
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnStock_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            Global.frm.Navigate(new salePage());

        }

        private void btnEmpoloyee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReports_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(Global.frm).Close();
            Application.Current.MainWindow.Show();
        }
    }
}
