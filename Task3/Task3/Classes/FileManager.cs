using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3.Classes
{
    /// <summary>
    /// Interface FileManager for control some file elems and had some value
    /// </summary>
    interface IFileManager
    {
        /// <summary>
        /// Method witch read file
        /// </summary>
        /// <param name="filePath"></param>
        void Read(string filePath);
        /// <summary>
        /// Method witch write to file
        /// </summary>
        /// <param name="filePath"></param>
        void Write(string filePath);
    }

}
