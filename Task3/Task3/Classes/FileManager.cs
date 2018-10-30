using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3.Classes
{

    interface IFileManager
    {
        void Read(string filePath);

        void Write(string filePath);
    }

}
