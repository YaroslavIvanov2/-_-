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
using Bronirovanie_Diplom.DB;
using Bronirovanie_Diplom.Pages;

namespace Bronirovanie_Diplom.Pages.WindowBronirovanie
{
    /// <summary>
    /// Логика взаимодействия для PageBronirovanie.xaml
    /// </summary>
    public partial class PageBronirovanie : Page
    {
        public PageBronirovanie()
        {
            InitializeComponent();
            serachDatePicker.SelectedDate = DateTime.Now.AddDays(1);
            Update();
        }
        public void Update()
        {
            DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            var spisok = DataBase.GetContext().Booking.ToList();
            //поиск
            if (!String.IsNullOrWhiteSpace(Searctextbox.Text))
            {
                spisok = spisok.Where(p => p.Name.Contains(Searctextbox.Text)).ToList();
            }
            // сортировка по дате
            if (serachDatePicker.SelectedDate != null)
                spisok = spisok.Where(p => p.Date.Date.Equals(serachDatePicker.SelectedDate)).ToList();
            spisokBroni.ItemsSource = spisok;
        }

        private void AddBroni_Click(object sender, RoutedEventArgs e)
        {
            WindowAddBroni windowAdd = new WindowAddBroni(this.Update);
            windowAdd.Show();
                
        }

        private void DeletBroni_Click(object sender, RoutedEventArgs e)
        {
            if (spisokBroni.SelectedItems.Count != 0) // проверка, выделен ли элемент в списке
            {
                List<Booking> bookings = spisokBroni.SelectedItems.OfType<Booking>().ToList();
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хоите удалить?", "Удаление", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DataBase.GetContext().Booking.RemoveRange(bookings);
                    DataBase.GetContext().SaveChanges();
                    DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    Update();
                }
            }
        }

        private void Searctextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void serachDatePicker_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var spisok = DataBase.GetContext().Booking.ToList();
            spisokBroni.ItemsSource = spisok;
        }

        private void RedacBroni_Click(object sender, RoutedEventArgs e)
        {
            if (spisokBroni.SelectedItem != null)
            {
                WindowRedactirovanie windowAdd = new WindowRedactirovanie(spisokBroni.SelectedItem as Booking);
                windowAdd.Show();
            }
        }
    }
}
