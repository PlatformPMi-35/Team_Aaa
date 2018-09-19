namespace Team_AAA.Task1
{
    using System;
    using System.Collections.Generic;
    using System.IO;
   
    /// <summary>  
    ///  Class Currency.
    /// </summary>  
    public class Currency : IReadable
    {
        /// <summary>
        /// Saves name of curency.
        /// </summary>
        public string CurrencyName { get; set; }

        /// <summary>
        /// Saves amout of currency.
        /// </summary>
        public double Amount { get; set; }

        /// <summary>  
        ///  Constructors without parametrs of class Currency.
        /// </summary> 
        public Currency()
        {
            CurrencyName = "None";
            Amount = 0.0;
        }

        /// <summary>
        /// Constructor with paramets.
        /// </summary>
        /// <param name="CurrencyName">Name of currency.</param>
        /// <param name="Amount">Amount of currency.</param>
        public Currency(string CurrencyName, double Amount)
        {
            this.CurrencyName = CurrencyName;
            this.Amount = Amount;
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
                        //if(sLine!="грн")
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
            foreach (Currency cur in ls)
            {
                if (cur.CurrencyName == "грн")
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
        public override string ToString() => "CurrencyName - " + this.CurrencyName + "\nAmount - " + this.Amount;
    }
}
