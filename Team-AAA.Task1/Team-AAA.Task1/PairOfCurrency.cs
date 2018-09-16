using System;
using System.Collections.Generic;
using System.IO;


namespace Team_AAA.Task1
{
    class PairOfCurrency
    {
        /// <summary>
        /// Saves all shapes to the file.
        /// </summary>
        /// <param name="filePath">A file path.</param>
        /// <param name="shapes">Collection of shapes.</param>
        /// <returns>True - if shapes successfully saved in the file, otherwise - false.</returns>
        public  bool Save(string filePath, Dictionary<string, double> List)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            using (var writer = new StreamWriter(filePath))
            {
                foreach (var i in List)
                {
                    writer.WriteLine("CurrencyName - " + i.Key + " Amount - " + i.Value);
                }
            }
            return true;
        }
        /// <summary>
        /// Does dictionary of pairs (currency name , amount)
        /// </summary>
        /// <param name="List">Container of currency</param>
        /// <returns></returns>
        public  Dictionary<string, double> DoPair(IEnumerable<Currency> List)
        {
            Dictionary<string, double> currencies = new Dictionary<string, double>();
            foreach (var i in List)
            {
                if (currencies.ContainsKey(i.CurrencyName))
                {
                    currencies[(i.CurrencyName)] += i.Amount;
                }
                else
                {
                    currencies.Add(i.CurrencyName, i.Amount);
                }
            }
            if (currencies.Count == 0)
            {
                throw new ArgumentNullException("Dictionary is empty!");
            }
            return currencies;
        }
    }
}
