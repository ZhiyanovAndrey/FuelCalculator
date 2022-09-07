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

namespace FuelCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double distance = 0;

        /// <summary>
        /// Расчет расхода топлива по расстоянию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                const double density = 0.76;
                double distance = Convert.ToDouble(TB_distance.Text);
                double av = Convert.ToDouble(averageExp.Text);

                double resL = distance * av / 100;
                double resKg = resL * density;

                resultKg.Text = resKg.ToString();
                resultL.Text = resL.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        /// <summary>
        /// Распознает текст в ComboBox и заменяет его значением расстояния
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string distanceString = (sender as ComboBox).SelectedItem.ToString();


            if (distanceString != null)
            {
                switch (distanceString)
                {
                    case "Арзамас1": distance = (int)Enum.Арзамас1; break;
                    case "Пешелань": distance = (int)Enum.Пешелань; break;
                    case "Шатки": distance = (int)Enum.Шатки; break;
                    case "Берещино": distance = (int)Enum.Берещино; break;
                    case "Поя": distance = (int)Enum.Поя; break;
                    case "Лукоянов": distance = (int)Enum.Лукоянов; break;
                    case "Веселей": distance = (int)Enum.Веселей; break;
                    case "Николай Дар": distance = (int)Enum.НиколайДар; break;
                    case "Арзинка": distance = (int)Enum.Арзинка; break;
                    case "Ужовка": distance = (int)Enum.Ужовка; break;
                    case "Кендя": distance = (int)Enum.Кендя; break;
                    case "Кемля": distance = (int)Enum.Кемля; break;
                    case "Оброчное": distance = (int)Enum.Оброчное; break;
                    case "Атьма": distance = (int)Enum.Атьма; break;
                    case "Красный Узел": distance = (int)Enum.КрасныйУзел; break;
                    case "Вурнары": distance = (int)Enum.Вурнары; break;
                    case "Пинер": distance = (int)Enum.Пинер; break;
                    case "Мыслец": distance = (int)Enum.Мыслец; break;
                    case "Шумерля через понтонный мост": distance = (int)Enum.ШумерляПонтон; break;
                    case "Шумерля через Порецкое": distance = (int)Enum.ШумерляПорецкое; break;
                    case "Шумерля через Лукоянов": distance = (int)Enum.ШумерляЛукоянов; break;
                    case "Княжиха": distance = (int)Enum.Княжиха; break;
                    case "Кумашка": distance = (int)Enum.Кумашка; break;
                    case "Пильна": distance = (int)Enum.Пильна; break;
                    case "Сергач": distance = (int)Enum.Сергач; break;
                    case "Тарталей": distance = (int)Enum.Тарталей; break;
                    case "Камкино": distance = (int)Enum.Камкино; break;
                    case "Каменище": distance = (int)Enum.Каменище; break;
                    case "Смагино": distance = (int)Enum.Смагино; break;
                    case "Кемары": distance = (int)Enum.Кемары; break;
                    case "Перевозская": distance = (int)Enum.Перевозская; break;
                    case "Ревезень": distance = (int)Enum.Ревезень; break;
                    case "Вадок": distance = (int)Enum.Вадок; break;
                    case "Бобыльская": distance = (int)Enum.Бобыльская; break;
                    case "Трактовый": distance = (int)Enum.Трактовый; break;
                    case "р.д.408": distance = (int)Enum.рд408; break;
                    default:
                        break;

                }
                TB_distance.Text = distance.ToString();
            }
        }
    }
}
