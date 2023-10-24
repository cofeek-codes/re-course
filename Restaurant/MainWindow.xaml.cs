using Restaurant.win;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
using System.Windows.Threading;

namespace Restaurant
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        string id = "";

        private kormyshevEntities _context = kormyshevEntities.GetContext();
        public MainWindow()
        {
            InitializeComponent();
            dispatcherTimer.Tick += (e, x) =>
            {
                DateTime dt = DateTime.Now;
                tbTime.Text = dt.ToString();
            };
            dispatcherTimer.Start();
            CreateHash("ygfruyeg");
        }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            var mb = MessageBox.Show("Вы уверены?", "Выйти?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (mb == MessageBoxResult.Yes)
            {
                dispatcherTimer.Stop();
                Application.Current.Shutdown();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(tboxLogin.Text) || string.IsNullOrWhiteSpace(pboxPassword.Password)))
            {

                var user = _context.User1.ToList().Find(x => x.Login == tboxLogin.Text && x.Password == CreateHash(pboxPassword.Password));

                if (user != null)
                {

                    MessageBox.Show("Добро пожаловать " + user.Firstname + " " + user.Surname, "Успешно");
                    userWin win = new userWin(user.RoleId, user.Firstname, user.Surname);
                    this.Hide();
                    win.ShowDialog();
                    return;

                }
                else
                {
                    user = _context.User1.ToList().Find(x => x.Login == tboxLogin.Text && CreateHash(x.Password) == CreateHash(pboxPassword.Password));
                    if (user != null)
                    {
                        btnChange.Visibility = Visibility.Visible;
                        tboxChangePassword.Visibility = Visibility.Visible;
                        id = user.id.ToString();
                        ResetForm(false);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка");

                        return;
                    }
                }
            }
            MessageBox.Show("Заполните форму", "Пустая форма");
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetForm(true);
        }

        private void ResetForm(bool x)
        {
            if (x)
            {
                var mb = MessageBox.Show("Вы уверены?", "Очистить форму?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                if (mb == MessageBoxResult.Yes)
                {
                    tboxLogin.Text = "";

                    pboxPassword.Password = "";
                }
            }
            else
            {
                tboxLogin.Text = "";

                pboxPassword.Password = "";
            }
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            var user = _context.User1.ToList().Find(x => x.id.ToString() == id);
            if (user != null)
            {
                user.Password = CreateHash(tboxChangePassword.Password);
            }
            try
            {
                _context.SaveChanges();
                btnChange.Visibility = Visibility.Hidden;
                tboxChangePassword.Visibility = Visibility.Hidden;
                MessageBox.Show("Пароль успешно сменен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Пароль не был сменен", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private string CreateHash(string pwd)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var hpwd = md5.ComputeHash(Encoding.UTF8.GetBytes(pwd));

                var p = Encoding.UTF8.GetString(hpwd);

                return p;
            }
        }
    }
}
