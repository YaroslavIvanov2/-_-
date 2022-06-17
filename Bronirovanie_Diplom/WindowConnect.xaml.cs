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
using Bronirovanie_Diplom.DB;

namespace Bronirovanie_Diplom
{
    /// <summary>
    /// Логика взаимодействия для WindowConnect.xaml
    /// </summary>
    public partial class WindowConnect : Window
    {
        private Employeer admin;
        public WindowConnect()
        {
            InitializeComponent();
            admin = new Employeer();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(loginTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Password))
            {
                MessageBox.Show("Введите данные во все поля");
                return;
            }
            if (DataBase.GetContext().Employeer.Where(p => p.Login == admin.Login && p.Password == admin.Password).ToList().Count != 1)
            {
                MessageBox.Show("Введены не правильно данные");
                return;
            }
            admin = DataBase.GetContext().Employeer.Where(p => p.Login == admin.Login && p.Password == admin.Password).ToList().First();
            MainWindow mainWindow = new MainWindow(admin);
            mainWindow.Owner = this;
            mainWindow.Show();
            this.Hide();
        }

        private void loginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            admin.Login = loginTextBox.Text;
        }

        private void passwordTextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            admin.Password = passwordTextBox.Password;
        }
    }
}
