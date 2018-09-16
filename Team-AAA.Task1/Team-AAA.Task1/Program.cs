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
        /// <summary>  
        ///  Interface IReadable for realization method Read() in class Currency.  
        /// </summary>  
        public interface IReadable
        {
            void Read(List<Currency> ls);
        }
        /// <summary>  
        ///  Class Currency.
        /// </summary>  
        public class Currency : IReadable
        {
            public string CurrencyName {get;set;}
            public double Amount {get;set;}
            /// <summary>  
            ///  Constructors of class Currency.
            /// </summary> 
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
            /// <summary>  
            ///  Method Read, for reading from file.
            /// </summary> 
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
            /// <summary>  
            ///  Method ShowUAN, for showing UAN only from list.
            /// </summary> 
            public void ShowUAN(List<Currency> ls)
            {
                foreach(Currency cur in ls)
                {
                    if (cur.CurrencyName == "UAN")
                    {
                        Console.WriteLine(cur.ToString());
                    }
                }
            }
            /// <summary>  
            ///  Method ShowALL, for showing all list elements.
            /// </summary> 
            public void ShowALL(List<Currency> ls)
            {
                foreach (Currency cur in ls)
                {
                   Console.WriteLine(cur.ToString());
                }
            }
            /// <summary>  
            /// Ovverided method ToString(), for methods ShowUAN and ShowALL.
            /// </summary> 
            public override string ToString()
            {
                return "CurrencyName - " + this.CurrencyName + "\nAmount - " + this.Amount;
            }
        }
        /// <summary>  
        ///  Main method, for all actions.
        /// </summary>  
        static void Main(string[] args)
        {
            Currency cur=new Currency();
            List<Currency> lcur=new List<Currency>();
            Console.WriteLine("-==All list==-");
            //
            cur.Read(lcur);
            cur.ShowALL(lcur);
            //
            Console.WriteLine();
            Console.WriteLine("-==Only UAN==-");
            //
            cur.ShowUAN(lcur);
            Console.ReadKey();
        }
    }
}
