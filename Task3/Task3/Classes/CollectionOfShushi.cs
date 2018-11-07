using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3.Classes
{
    public class CollectionOfShushi:IFileManager
    {
        public List<Sushi> list;

        public CollectionOfShushi()
        {
            list = new List<Sushi>();
        }
 
        public void Read(string filePath)
        {
            StreamReader Reader = new StreamReader(filePath, System.Text.Encoding.Default);
            string sLine = Reader.ReadLine();
            while (sLine != null)
            {
                string[] fields = sLine.Split();
                list.Add(new Sushi(fields[0], Convert.ToDouble(fields[1]), Convert.ToDouble(fields[2]), fields[3]));
                sLine = Reader.ReadLine();
            }
            Reader.Close();
        }

        public void Write(string filePath)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            using (StreamWriter writer = File.AppendText(filePath))
            {
                foreach (var i in list)
                {
                    string h = i.ToWrite();
                    writer.WriteLine(h);
                }
            }
        }

        public void Add(Sushi toAdd)
        {
            if(list.Find(x=>x.name==toAdd.name)!=null||!toAdd.isGood())
            {
                throw new ArgumentNullException("This item is already in list or it is empty!");
            }
            else
            {
                list.Add(toAdd);
            }
        }

        public void DeleteByName(string nameToDelete)
        {
            foreach(var i in list)
            {
                if(i.name==nameToDelete)
                {
                    list.Remove(i);
                }
            }
        }

        public List<Sushi> getList()
        {
            return list;
        }
    }
}
