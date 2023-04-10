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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private DateTime _day;
        private havkaModel model = new havkaModel();
        public Page2(DateTime day) //потом сюда полностью дату передай, не только день
        {
            InitializeComponent();
            _day = day;
            model.time = day; //не нау, а дата, которую ты передал сюда
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Здесь происходит логика сохранения информации о том, что пользователь выбрал в этот день есть.
            globalssssss.hhavkaList.Add(model);
            MessageBox.Show($"Данные для дня {_day} успешно сохранены!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            model.selectedKmopka = 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            model.selectedKmopka = 2;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            model.selectedKmopka = 3;

        }
    }
}