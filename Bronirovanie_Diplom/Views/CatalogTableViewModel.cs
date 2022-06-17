using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bronirovanie_Diplom.DB;

namespace Bronirovanie_Diplom.Views
{
    class CatalogTableViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Table> Table { get; set; }
        public CatalogTableViewModel()
        {
            Table = new ObservableCollection<Table>();
            UpdateList();
        }


        public void UpdateList()
        {
            try
            {
                Table.Clear();
                List<Table> table = DataBase.GetContext().Table.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка:" + e.Message);
            }
        }
    }
}
