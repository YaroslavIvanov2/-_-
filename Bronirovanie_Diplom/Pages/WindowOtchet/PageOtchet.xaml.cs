using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bronirovanie_Diplom.DB;

namespace Bronirovanie_Diplom.Pages.WindowOtchet
{
    /// <summary>
    /// Логика взаимодействия для PageOtchet.xaml
    /// </summary>
    public partial class PageOtchet : Page
    {
        public PageOtchet()
        {
            InitializeComponent();
            // добавление названия и полос данных
            cha.Titles.Add("Данные по столикам");
            cha.ChartAreas.Add(new ChartArea("Default"));
            cha.Series.Add(new Series("Количество свободных столов")
            {
                ChartType = SeriesChartType.Column
                
                
            });
            cha.Series.Add(new Series("Количество занятых столов")
            {
                ChartType = SeriesChartType.Column
            });
            //список свободных столов
            List<int> rait = new List<int>();
            List<int> name = new List<int>();
            //список занятых столов
            List<int> rait2 = new List<int>();
            List<int> name2 = new List<int>();
            //с помощью оператора вызываем таблицу и присваеваем атрибутам выше созданные переменные 
            foreach (Table_Svobodnie files in DataBase.GetContext().Table_Svobodnie)
            {
                rait.Add((int)files.Number_of_seats);
                //здесь присваиваем переменную и одновременно вызываем из другой таблицы атрубут 
                name.Add(Convert.ToInt16(DataBase.GetContext().Table_Svobodnie.Where(x => x.id_svobonie == files.id_svobonie).FirstOrDefault().id_svobonie));
            }
            foreach (Table_zaniti files in DataBase.GetContext().Table_zaniti)
            {
                rait2.Add((int)files.Number_of_seats);
                //здесь присваиваем переменную и одновременно вызываем из другой таблицы атрубут 
                name2.Add(Convert.ToInt16(DataBase.GetContext().Table_zaniti.Where(x => x.id_zanzti == files.id_zanzti).FirstOrDefault().id_zanzti));
            }
            //здесь присваеваем переменными координаты
            cha.Series["Количество свободных столов"].Points.DataBindXY(name, rait);
            cha.Series["Количество занятых столов"].Points.DataBindXY(name2, rait2);
        }
    }
}
