using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Task3.Classes
{
    class CommandForButton
    {
        public static RoutedCommand Delete { get; set; }
        public static RoutedCommand ToList { get; set; }

        static CommandForButton()
        {
            Delete = new RoutedCommand("Delete", typeof(MainWindow));
            ToList = new RoutedCommand("ToList", typeof(MainWindow));    
        }
    }
}
