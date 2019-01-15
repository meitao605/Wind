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

namespace WindMeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static private double Radial = 250;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Trans_30.X = (Radial + 15*Math.Sin(Math.PI/6))* Math.Sin(Math.PI/6);
            Trans_30.Y = 250 - (Radial + 15 * Math.Sin(Math.PI / 6))* Math.Cos(Math.PI/6);

            Trans_60.X = (Radial + 15 * Math.Sin(Math.PI / 3)) * Math.Sin(Math.PI / 3);
            Trans_60.Y = 250 - (Radial + 15 * Math.Sin(Math.PI / 3)) * Math.Cos(Math.PI / 3);
        }


    }
}
