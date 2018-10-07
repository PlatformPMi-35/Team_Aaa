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

namespace ShapesWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            PointCollection cl = new PointCollection();
            cl.Add(new Point(15, 200));
            cl.Add(new Point(68, 70));
            cl.Add(new Point(110, 200));
            cl.Add(new Point(0, 125));
            cl.Add(new Point(155, 150));
            Polygon a = new Polygon
            {
                Name = "fuck",
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Fill = Brushes.Yellow,
                Points = cl
            };
            bCanvas.Children.Add(a);
            Canvas.SetLeft(a, 200);
            Canvas.SetTop(a, 100);
            fuck.Fill = Brushes.Pink;
        }

        private void New_form_Click(object sender, RoutedEventArgs e)
        {
            Dialog a = new Dialog(bCanvas);
            a.Owner = this;
            a.Show();
        }
    }
}
