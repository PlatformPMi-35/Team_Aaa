namespace Team_AAA.Task1
{
    using System;
    using System.Collections.Generic;
    using Team_AAA.Task1.Classes_and_interfaces;

    /// <summary>  
    ///  Program class.
    /// </summary>  
    public class Program
    {
        public const double DOLLAR_VALUE = 28.13;
        public const double EURO_VALUE = 32.71;
        public const double UAH_VALUE = 1;

        /// <summary>  
        ///  Main method, for all actions.
        /// </summary>  
        public static void Main(string[] args)
        {
            int choice;
            Dictionary<CurrencyName, double> currencies = new Dictionary<CurrencyName, double>();
            Dictionary<CurrencyName, double> resultOfConversion = new Dictionary<CurrencyName, double>();
            Currency cur = new Currency();
            List<Currency> lcur = new List<Currency>();
            Console.WriteLine("-==All list==-");
            ////
            try
            {
                cur.Read(lcur);
           
            cur.ShowALL(lcur);
            ////
            Console.WriteLine();
            Console.WriteLine("-==Only грн==-");
            ////
            cur.ShowUAN(lcur);
            Console.WriteLine("-==By pairs==-");
            currencies = PairOfCurrency.DoPair(lcur);
            FileManager.Save("../../Result.txt", currencies);
            Console.WriteLine("-==Succesfully saved to file==-");
            
            Console.WriteLine("Choose to what currency convert all money \n1 for Dollar, 2 - Euro and 3 for UAH:");
            
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    resultOfConversion = Conversion.To(currencies, CurrencyName.Dollar);
                    FileManager.Save("../../ResultOfConversion.txt", resultOfConversion);
                }
                else if (choice == 2)
                {
                    resultOfConversion = Conversion.To(currencies, CurrencyName.Euro);
                    FileManager.Save("../../ResultOfConversion.txt", resultOfConversion);
                }
                else if (choice == 3)
                {
                    resultOfConversion = Conversion.To(currencies, CurrencyName.UAH);
                    FileManager.Save("../../ResultOfConversion.txt", resultOfConversion);

                }
                else throw new ArgumentNullException("Wrong choice of conversion!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                ////Console.ReadKey();
            }
            Console.ReadKey();
            ////Testing
        }
    }
}
