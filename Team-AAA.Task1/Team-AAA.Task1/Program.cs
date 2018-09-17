using System;
using System.Collections.Generic;


namespace Team_AAA.Task1
{
    class Program
    {

        
        /// <summary>  
        ///  Main method, for all actions.
        /// </summary>  
        static void Main(string[] args)
        {

            Dictionary<string, double> currencies = new Dictionary<string, double>();
            PairOfCurrency Pair=new PairOfCurrency();
            Currency cur=new Currency();
            List<Currency> lcur=new List<Currency>();
            Console.WriteLine("-==All list==-");
            //
            cur.Read(lcur);
           
            cur.ShowALL(lcur);
            //
            Console.WriteLine();
            Console.WriteLine("-==Only грн==-");
            //
            cur.ShowUAN(lcur);
            Console.WriteLine("-==By pairs==-");
            currencies = Pair.DoPair(lcur);
            var t = Pair.Save("../../Result.txt", currencies);
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
