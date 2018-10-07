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
using System.Windows.Shapes;

namespace ShapesWPF
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class Dialog : Window
    {
        Canvas c;
        public Dialog()
        {
            InitializeComponent();
        }
        public Dialog(Canvas c)
        {
            InitializeComponent();
            this.c = c;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            PointCollection cl = new PointCollection();
            cl.Add(new Point(15, 200));
            cl.Add(new Point(68, 70));
            cl.Add(new Point(110, 200));
            cl.Add(new Point(0, 125));
            cl.Add(new Point(155, 160));
            Polygon a = new Polygon
            {
                Name = "fuck",
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Fill = Brushes.Yellow,
                Points = cl
            };
            c.Children.Add(a);
            Canvas.SetLeft(a, int.Parse(textBox.Text));
            Canvas.SetTop(a, int.Parse(textBox1.Text));
            this.Close();
        }
    }
}
