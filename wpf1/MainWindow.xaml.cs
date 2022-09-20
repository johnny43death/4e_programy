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

namespace wpf1
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

        /*private void btn_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBox.Text;
        }*/

        /*private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBlock.FontSize = slider.Value;
            wartosc.Text = String.Format("{0:F2}", e.NewValue);
        }*/

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            textBlock.FontSize = slider.Value;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Foreground = red.Background;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Foreground = green.Background;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Foreground = blue.Background;
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Foreground = yellow.Background;
        }
    }
}
