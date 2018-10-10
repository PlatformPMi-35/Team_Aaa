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
    /// Логика взаимодействия для NewCanvas.xaml
    /// </summary>
    public partial class NewCanvas : Window
    {
        Canvas s;
        public NewCanvas(Canvas s)
        {
            InitializeComponent();
            this.s = s;
        }
    }
}
