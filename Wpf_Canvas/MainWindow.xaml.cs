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

namespace Wpf_Canvas
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Canvas leinwand = new Canvas();

            leinwand.Width = 500;
            leinwand.Height = 500;

            leinwand.Background = Brushes.Beige;

            Rectangle rechteck = new Rectangle();
            rechteck.Height = 100;
            rechteck.Width = 100;
            rechteck.Stroke = Brushes.Coral;
            rechteck.StrokeThickness = 10;

            Canvas.SetLeft(rechteck, 200);
            Canvas.SetTop(rechteck, 200);

            leinwand.Children.Add(rechteck);

            Content = leinwand;

        }
    }
}
