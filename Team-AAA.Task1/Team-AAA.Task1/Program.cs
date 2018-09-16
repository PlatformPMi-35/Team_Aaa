using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_AAA.Task1
{
    class Program
    {
        public interface IReadable
        {
            void Read();
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
        }
        //
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
