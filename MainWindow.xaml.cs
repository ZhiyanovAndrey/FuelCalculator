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

        public double distance=0;

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
                    case "Москва-Екатеринбург":
                        distance = 1801;
                        break;
                    case "Екатеринбург-Владивосток":
                        distance = 7489;
                        break;
                    case "Екатеринбург-Токио":
                        distance = 9164;
                        break;
                    default:
                        break;

                }
                TB_distance.Text=distance.ToString();      
            }
        }
    }
}
