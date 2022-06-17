using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using Microsoft.Win32;

namespace Bronirovanie_Diplom.Pages.WindowTable
{
    /// <summary>
    /// Логика взаимодействия для WindowRedactirovanieStolika.xaml
    /// </summary>
    public partial class WindowRedactirovanieStolika : Window
    {
        DB.Table table;
        private ImageHelp imageHelp { get; set; }
        
        public WindowRedactirovanieStolika(DB.Table tables)
        {
            InitializeComponent();
            table = tables;
            DataContext = table;
            imageHelp = new ImageHelp() { Products = table };
            Photo.DataContext = imageHelp;
        }
        class ImageHelp : INotifyPropertyChanged
        {
            public DB.Table Products { get; set; }
            public string Image
            {
                get => Products.image;
                set
                {
                    Products.image = value;
                    OnPropertyChanged("Image");
                }
            }
            private void OnPropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            public event PropertyChangedEventHandler PropertyChanged;
        }


        private void AddImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files| *.jpg; *.png";
            if (openFileDialog.ShowDialog() == true)
            {

                try
                {
                    string path = "Stoli/" + DateTime.Now.ToBinary().ToString() + System.IO.Path.GetExtension(openFileDialog.FileName);
                    File.Copy(openFileDialog.FileName, System.IO.Path.GetFullPath(path));
                    imageHelp.Image = "" + path;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!DataBase.GetContext().Table.ToList().Contains(table))
                {
                    DataBase.GetContext().Table.Add(table);
                }
                DataBase.GetContext().SaveChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
