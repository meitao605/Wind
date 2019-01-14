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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(Left_Out_Circle, left_meter.ActualWidth / 2-250);
            Canvas.SetTop(Left_Out_Circle, left_meter.ActualHeight / 2 - 250);

        }

        private void Left_meter_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Canvas.SetLeft(Left_Out_Circle, left_meter.ActualWidth / 2 - 250);
            Canvas.SetTop(Left_Out_Circle, left_meter.ActualHeight / 2 - 250);
            DrawScale();

        }

        private void DrawScale()
        {
            double CenterX = left_meter.ActualWidth / 2;
            double CenterY = left_meter.ActualHeight / 2;


        }
    }
}
