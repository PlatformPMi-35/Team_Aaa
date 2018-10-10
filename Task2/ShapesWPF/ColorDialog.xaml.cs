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
        Polygon testPolygon = new Polygon();
        public ColorDialog(Polygon pol)
        {
            InitializeComponent();
            testPolygon = pol;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int q = comboBox.SelectedIndex;
            switch (q)
            {
                case 0: testPolygon.Fill = Brushes.Purple; break;
                case 1: testPolygon.Fill = Brushes.Black; break;
                case 2: testPolygon.Fill = Brushes.Red; break;
                case 3: testPolygon.Fill = Brushes.Green; break;
                case 4: testPolygon.Fill = Brushes.Pink; break;
                default:
                    break;
            }
            this.Close();
        }

        private void comboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
