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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public DateTime DateTimeNow { get; set; } = DateTime.Now;
        public Page1()
        {
            InitializeComponent();
            DataContext = this;

            DataeEbat invar = new DataeEbat();
            DataBut();
        }

        private void Button_Click_Left(object sender, RoutedEventArgs e)
        {

            myWrapPanel.Children.Clear();
            DateTimeNow = DateTimeNow.AddMonths(-1);
            TbDate.Text = DateTimeNow.ToString("MMMM yyyy");
            DataBut();
        }

        private void Button_Click_Right(object sender, RoutedEventArgs e)
        {

            myWrapPanel.Children.Clear();
            DateTimeNow = DateTimeNow.AddMonths(1);
            TbDate.Text = DateTimeNow.ToString("MMMM yyyy");
            DataBut();
        }

        private void DataBut()
        {
            for (int i = 1; i <= DateTime.DaysInMonth(DateTimeNow.Year, DateTimeNow.Month); i++)
            {
                DataeEbat ebat = new DataeEbat();
                ebat.DataName.Content = i.ToString();

                DateTime datesukavotsuda = new DateTime(DateTimeNow.Year, DateTimeNow.Month, i);
                havkaModel item = globalssssss.hhavkaList.FirstOrDefault(iteminlist => iteminlist.time == datesukavotsuda);
                if (item != null)
                {
                    if (item.selectedKmopka == 1)
                    {
                        ebat.DataName.Background = new ImageBrush(new BitmapImage(new Uri("C:\\Users\\root\\Desktop\\calendar\\WpfApp1\\viob_del\\pipka1.png")))
                        {
                            Stretch = Stretch.Fill,
                            ViewportUnits = BrushMappingMode.Absolute,
                            Viewport = new Rect(25, 0, 50, 50)
                        };

                    }
                    else if (item.selectedKmopka == 2)
                    {
                        ebat.DataName.Background = new ImageBrush(new BitmapImage(new Uri("C:\\Users\\root\\Desktop\\calendar\\WpfApp1\\viob_del\\pipka2.png")))
                        {
                            Stretch = Stretch.Fill,
                            ViewportUnits = BrushMappingMode.Absolute,
                            Viewport = new Rect(25, 0, 50, 50)
                        };
                    }
                    else if (item.selectedKmopka == 3)
                    {
                        ebat.DataName.Background = new ImageBrush(new BitmapImage(new Uri("C:\\Users\\root\\Desktop\\calendar\\WpfApp1\\viob_del\\pipka3.png")))
                        {
                            Stretch = Stretch.Fill,
                            ViewportUnits = BrushMappingMode.Absolute,
                            Viewport = new Rect(25, 0, 50, 50)
                        };
                    }
                }

                ebat.DataName.Click += DataName_Click;
                myWrapPanel.Children.Add(ebat);
            }
        }

        private void DataName_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int day = Convert.ToInt32(btn.Content);
            DateTime datesukavotsuda = new DateTime(DateTimeNow.Year, DateTimeNow.Month, day);
            // Далее открываем страницу для выбора продуктов и т.д.

            Window1 window1 = new Window1(datesukavotsuda);

            window1.Show();

/*            Page2 page2 = new Page2(datesukavotsuda);
            NavigationService.Navigate(page2);*/
        }
    }
}
