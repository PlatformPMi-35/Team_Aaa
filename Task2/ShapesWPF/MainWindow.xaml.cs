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
        int z = 1;
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
            z=1;
        }

        public void ExportToPng(Canvas surface)
        {

            // Save current canvas transform
            Transform transform = surface.LayoutTransform;
            // reset current transform (in case it is scaled or rotated)
            surface.LayoutTransform = null;

            // Get the size of canvas
            Size size = new Size(surface.Width, surface.Height);
            // Measure and arrange the surface
            // VERY IMPORTANT
            surface.Measure(size);
            surface.Arrange(new Rect(size));

            // Create a render bitmap and push the surface to it
            RenderTargetBitmap renderBitmap =
              new RenderTargetBitmap(
                (int)size.Width,
                (int)size.Height,
                96d,
                96d,
                PixelFormats.Pbgra32);
            renderBitmap.Render(surface);

            // Create a file stream for saving image
            using (FileStream outStream = new FileStream("../../Res.jpeg", FileMode.Create))
            {
                // Use png encoder for our data
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                // push the rendered bitmap to it
                encoder.Frames.Add(BitmapFrame.Create(renderBitmap));
                // save the data to the stream
                encoder.Save(outStream);
            }

            // Restore previously saved layout
            surface.LayoutTransform = transform;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        public void MainMenuAdd(string NameOfFigure)
        {
            MenuItem menuShape = new MenuItem();
            menuShape.Header = NameOfFigure;
            this.Menu_it.Items.Add(menuShape);
        }
        PointCollection polcol= new PointCollection();
        int i = 0; 
        private void DrawCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //pointCollection = new PointCollection();
            //pointCollection.Add(new Point(15, 100));
            //pointCollection.Add(new Point(68, 70));
            //pointCollection.Add(new Point(110, 200));
            //pointCollection.Add(new Point(0, 125));
            //pointCollection.Add(new Point(155, 150));
            Point pp = new Point();
            pp = Mouse.GetPosition(this);
            
            polcol.Add(pp);
            ++i;
            if (i > 4)
            {
                Polygon newP = new Polygon
                {
                    Name = "",
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    Fill = Brushes.Yellow,
                    Points = polcol
                };
                ColorDialog a = new ColorDialog(newP);
                a.Owner = this;
                a.Show();
                DrawCanvs.Children.Add(newP);
                MainMenuAdd("_Pentagram "+z);
                polcol = new PointCollection();
                i = 0;
                z++;
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
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

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Image documents (.jpeg)|*.jpeg";
            openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName;
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri(fileName, UriKind.Relative));
            DrawCanvs.Background = brush;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ExportToPng(DrawCanvs);
        }
    }
}
