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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            switch (TB_distance.Text)
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
                const double density = 0.76;
                //double distanceString = Convert.ToDouble(TB_distance.Text);
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string distanceString = (sender as ComboBox).SelectedItem.ToString();


        }
    }
}
