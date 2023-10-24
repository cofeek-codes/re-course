using Restaurant.pages;
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
using System.Windows.Threading;

namespace Restaurant.win
{
    /// <summary>
    /// Логика взаимодействия для userWin.xaml
    /// </summary>
    public partial class userWin : Window
    {
        private int roleId; private string firstName, surName;

        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private kormyshevEntities _context = kormyshevEntities.GetContext();

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.MainWindow.Show();
        }

        public userWin(int roleId, string firstName, string surName)
        {
            InitializeComponent();
            this.roleId = roleId;
            this.firstName = firstName;
            this.surName = surName;
            dispatcherTimer.Tick += (e, x) =>
            {
                DateTime dt = DateTime.Now;
                tbTime.Text = dt.ToString();
            };
            dispatcherTimer.Start();
            Title = _context.Role1.ToList().Find(x => x.id == roleId).Name + " " + firstName + " " + surName;
            var p = new mainPage(this.roleId);
            Global.frm = frmMain;
            frmMain.Navigate(p);
        }




    }
}
