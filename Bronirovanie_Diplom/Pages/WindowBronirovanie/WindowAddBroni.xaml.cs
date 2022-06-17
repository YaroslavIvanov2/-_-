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

namespace Bronirovanie_Diplom.Pages.WindowBronirovanie
{
    /// <summary>
    /// Логика взаимодействия для WindowAddBroni.xaml
    /// </summary>
    public partial class WindowAddBroni : Window
    {
        Booking booking;
        private Action update;
        public WindowAddBroni(Action update)
        {
            InitializeComponent();
            this.update = update;
            booking = new Booking();
            DataContext = booking;
            sotrydnikBox.ItemsSource = DataBase.GetContext().Employeer.ToList();
            StolicBox.ItemsSource = DataBase.GetContext().Table.ToList();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (!DataBase.GetContext().Booking.ToList().Contains(booking))
                {
                    DataBase.GetContext().Booking.Add(booking);
                }
                DataBase.GetContext().SaveChanges();
                update();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
