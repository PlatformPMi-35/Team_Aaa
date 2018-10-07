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
    /// Interaction logic for ColorDialog.xaml
    /// </summary>
    public partial class ColorDialog : Window
    {
        Canvas c;
        Polygon p;
        int x, y;
        Brush cc;
        public ColorDialog()
        {
            InitializeComponent();
        }
        public ColorDialog(Canvas c, Polygon a, int xx, int yy)
        {
            p = a;
            InitializeComponent();
            this.c = c;
            x = xx; y = yy;
            //this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int q = comboBox.SelectedIndex;
            switch (q)
            {
                case 0:cc = Brushes.Purple; break;
                case 1: cc = Brushes.Black; break;
                case 2: cc = Brushes.Red; break;
                case 3: cc = Brushes.Green; break;
                case 4: cc = Brushes.Pink; break;
                default:
                    break;
            }
            p.Fill = cc;
            c.Children.Add(p);
            Canvas.SetLeft(p, x);
            Canvas.SetTop(p, y);
            this.Close();
        }

        private void comboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
