using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Bronirovanie_Diplom.DB;
using Bronirovanie_Diplom.Pages.WindowBronirovanie;
using Bronirovanie_Diplom.Pages.WindowTable;
using Bronirovanie_Diplom.Pages.WindowOtchet;

namespace Bronirovanie_Diplom.Views
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private void PropertyChange(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public event PropertyChangedEventHandler PropertyChanged;
        public Employeer admin { get; private set; }
        public ObservableCollection<Page> PageCollection { get; private set; }
        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    PropertyChange("CurrentPage");
                }
            }
        }
        internal void UpdateVrach()
        {
            throw new NotImplementedException();
        }

        public MainWindowViewModel(Employeer admin)
        {
            this.admin = admin;
            PageCollection = new ObservableCollection<Page>();
            PageCollection.Add(new PageBronirovanie());
            PageCollection.Add(new PageStolici());
            PageCollection.Add(new PageOtchet());
            CurrentPage = PageCollection[0];

        }

    }
}
