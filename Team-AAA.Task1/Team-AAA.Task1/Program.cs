using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Team_AAA.Task1
{
    class Program
    {
        
        public interface IReadable
        {
            void Read(List<Currency> ls);
        }
        //
        public class Currency : IReadable
        {
            public string CurrencyName {get;set;}
            public double Amount {get;set;}
            //
            public Currency()
            {
                CurrencyName="None";
                Amount=0.0;
            }
            public Currency(string CurrencyName,double Amount)
            {
                this.CurrencyName=CurrencyName;
                this.Amount=Amount;
            }
            //
            public void Read(List<Currency> ls)
            {
               StreamReader Reader = new StreamReader("File.txt", System.Text.Encoding.Default);
               string sLine = "";
               while (sLine != null)
               {
                   Currency tmp = new Currency();

                   for (int i = 0; i < 2; i++)
                   {
                    
                       sLine = Reader.ReadLine();
        
                       if (sLine == null)
                       {
                           return;
                       }
                    
                       if (i == 0 && sLine != null)
                       {
                          tmp.CurrencyName = sLine;
                       }
                       else if (i == 1 && sLine != null)
                       {
                           tmp.Amount = double.Parse(sLine);
                       }
                   }
                   ls.Add(tmp);
               }
               Reader.Close();
            }
            //
            public void ShowUAN(List<Currency> ls)
            {
                foreach(Currency cur in ls)
                {
                    cur.ToString();
                }
            }
            //
            public override string ToString()
            {
                return CurrencyName + Amount;
            }
        }
        //
        static void Main(string[] args)
        {
            Currency cur=new Currency();
            List<Currency> lcur=new List<Currency>();
            cur.Read(lcur);
            cur.ShowUAN(lcur);
            Console.ReadKey();
        }
    }
}
