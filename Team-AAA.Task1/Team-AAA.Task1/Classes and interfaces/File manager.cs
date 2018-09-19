using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_AAA.Task1.Classes_and_interfaces
{
    /// <summary>
    /// Class to write in file
    /// </summary>
    public class FileManager
    {

        /// <summary>
        /// Saves all currenencies to the file.
        /// </summary>
        /// <param name="filePath">A file path.</param>
        /// <param name="shapes">Collection of shapes.</param>
        /// <returns>True - if shapes successfully saved in the file, otherwise - false.</returns>
        public static bool Save(string filePath, Dictionary<CurrencyName, double> List)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            using (var writer = new StreamWriter(filePath))
            {
                foreach (var i in List)
                {
                    writer.WriteLine("CurrencyName - " + i.Key + " Amount - " + Math.Round(i.Value, 2));
                }
            }
            return true;
        }
    }
}
