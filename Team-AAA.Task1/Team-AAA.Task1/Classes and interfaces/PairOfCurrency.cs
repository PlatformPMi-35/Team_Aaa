using System;
using System.Collections.Generic;
using System.IO;


namespace Team_AAA.Task1
{
    /// <summary>
    /// Class to make dictionary of currencies
    /// </summary>
    class PairOfCurrency
    {
        
        /// <summary>
        /// Does dictionary of pairs (currency name , amount)
        /// </summary>
        /// <param name="List">Container of currency</param>
        /// <returns></returns>
        public static Dictionary<CurrencyName, double> DoPair(IEnumerable<Currency> List)
        {
            Dictionary<CurrencyName, double> currencies = new Dictionary<CurrencyName, double>();
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
