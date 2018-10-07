namespace Team_AAA.Task1.Classes_and_interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>  
    ///  Class of conversion Currency names.
    /// </summary> 
    public class ConverterToCurrencyName
    {

        /// <summary>  
        ///  Convert function.
        /// </summary> 
        public static CurrencyName Convert(string toConvert)
        {
            CurrencyName result = CurrencyName.None;
            if (toConvert == "грн")
            {
                result = CurrencyName.UAH;
            }
            else if (toConvert == "$")
            {
                result = CurrencyName.Dollar;
            }
            else if (toConvert == "Є")
            {
                result = CurrencyName.Euro;
            }
            return result;
        }
    }
}
