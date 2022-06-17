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
using Bronirovanie_Diplom.Views;

namespace Bronirovanie_Diplom.Pages.WindowTable
{
    /// <summary>
    /// Логика взаимодействия для PageStolici.xaml
    /// </summary>
    public partial class PageStolici : Page
    {
        CatalogTableViewModel catalog;

        public PageStolici()
        {
            InitializeComponent();
            // catalog = new CatalogTableViewModel();
            //DataContext = catalog;
            Update();
            DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
        }

        public void Update()
        {
            DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            List<DB.Table> spisok = DataBase.GetContext().Table.ToList();
            /*int id = 0;
            if (!String.IsNullOrWhiteSpace(SearchBox.Text))
            {
                id = Int32.Parse(SearchBox.Text.Trim());
                //spisok = spisok.Where(p => p.id_table.Contains(SearchBox.Text)).ToList();
                spisok = (List<DB.Table>)spisok.Where(p => p.Number_of_seats == id);
            }*/
            spisok2.ItemsSource = spisok;
            spisok1.ItemsSource = spisok;
        }

        private void addTable_Click(object sender, RoutedEventArgs e)
        {
            WindowAddStolic addStolic = new WindowAddStolic(this.Update);
            addStolic.Show();
        }

        private void redactorTable_Click(object sender, RoutedEventArgs e)
        {
            if (spisok2.SelectedItem != null)
            {
                WindowRedactirovanieStolika windowAdd = new WindowRedactirovanieStolika(spisok2.SelectedItem as DB.Table);
                windowAdd.Show();
            }
        }

        private void deleteTable_Click(object sender, RoutedEventArgs e)
        {
            if (spisok2.SelectedItems.Count != 0) // проверка, выделен ли элемент в списке
            {
                List<DB.Table> tables = spisok2.SelectedItems.OfType<DB.Table>().ToList();
                MessageBoxResult messageBoxResult = MessageBox.Show("Вы действительно хоите удалить?", "Удаление", MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    DataBase.GetContext().Table.RemoveRange(tables);
                    DataBase.GetContext().SaveChanges();
                    DataBase.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    Update();
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
    }
}
