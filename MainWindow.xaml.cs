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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            const double density = 0.76; 
            double l = Convert.ToDouble(length.Text);
            double av = Convert.ToDouble(averageExp.Text);

            double resL = l * av/100;
            double resKg = resL*density;

            resultKg.Text = resKg.ToString();
            resultL.Text = resL.ToString();

            
        }
    }
}
