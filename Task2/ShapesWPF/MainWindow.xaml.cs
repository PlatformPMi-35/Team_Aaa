﻿using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace ShapesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Polygon newPolygon;
        PointCollection pointCollection;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            pointCollection = new PointCollection();
            pointCollection.Add(new Point(15, 200));
            pointCollection.Add(new Point(68, 70));
            pointCollection.Add(new Point(110, 200));
            pointCollection.Add(new Point(0, 125));
            pointCollection.Add(new Point(155, 150));
            newPolygon = new Polygon
            {
                Name = "",
                Stroke = Brushes.Black,
                StrokeThickness = 1,
                Fill = Brushes.Yellow,
                Points = pointCollection
            };
            bCanvas.Children.Add(newPolygon);
            Canvas.SetLeft(newPolygon, 200);
            Canvas.SetTop(newPolygon, 100);
            fuck.Fill = Brushes.Pink;
        }

        int count = 0;

        private void New_form_Click(object sender, RoutedEventArgs e)
        {
            Dialog a = new Dialog(bCanvas);
            a.Owner = this;
            a.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count > 2)
            {
                count = 0;
                Dialog a = new Dialog(bCanvas);
                a.Owner = this;
                a.Show();
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

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
    }
}