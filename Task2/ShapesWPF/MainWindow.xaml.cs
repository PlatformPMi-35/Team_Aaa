using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace ShapesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        PointCollection pointCollection;
        public MainWindow()
        {
            InitializeComponent();

        }
        Polygon pol = new Polygon();


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DrawCanvs.Children.Clear();
            Menu_it.Items.Clear();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (pointCollection == null)
            {
                MessageBox.Show("Point collection is empty", "", MessageBoxButton.OK);
            }
            else
            {
                XmlSerializer formatter = new XmlSerializer(typeof(PointCollection));
                using (FileStream fs = new FileStream("../../Polygon.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, pointCollection);
                }
                MessageBox.Show("Was written in xml file \"Polygon.xml\"", "", MessageBoxButton.OK);
            }
        }

        public void MainMenuAdd(string NameOfFigure)
        {
            MenuItem menuShape = new MenuItem();
            menuShape.Header = NameOfFigure;
            this.Menu_it.Items.Add(menuShape);
        }

        int i = 0,z=0;
        PointCollection[] polcol = new PointCollection[1000];
        private void DrawCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            polcol[z] = new PointCollection();
            //pointCollection = new PointCollection();
            //pointCollection.Add(new Point(15, 100));
            //pointCollection.Add(new Point(68, 70));
            //pointCollection.Add(new Point(110, 200));
            //pointCollection.Add(new Point(0, 125));
            //pointCollection.Add(new Point(155, 150));
            Point pp = new Point();
            pp = Mouse.GetPosition(this);
            
            polcol[z].Add(pp);
            ++i; ++z;
            if (i > 4)
            {
                Polygon newP = new Polygon
                {
                    Name = "",
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    Fill = Brushes.Yellow,
                    Points = polcol[z]
                };
                ColorDialog a = new ColorDialog(newP);
                a.Owner = this;
                a.Show();
                DrawCanvs.Children.Add(newP);
                MainMenuAdd("_Pentagram");
                i = 0;
            }
        }

    }
}
