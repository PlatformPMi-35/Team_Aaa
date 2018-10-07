namespace GitTest
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Team_AAA.Task1;
    using Team_AAA.Task1.Classes_and_interfaces;

    [TestClass]

    /// <summary>  
    ///  Test class.
    /// </summary>
    public class UnitTest1
    {
        public const double DOLLAR_VALUE = 28.13;
        public const double EURO_VALUE = 32.71;
        public const double UAH_VALUE = 1;

        ////Next 4 - currency name convertion tests
        [TestMethod]
        public void HryvnaTest()
        {
            CurrencyName a;
            a = ConverterToCurrencyName.Convert("грн");
            Assert.AreEqual(a, CurrencyName.UAH);
        }

        [TestMethod]
        public void DollarTest()
        {
            CurrencyName a;
            a = ConverterToCurrencyName.Convert("$");
            Assert.AreEqual(a, CurrencyName.Dollar);
        }

        [TestMethod]
        public void EuroTest()
        {
            CurrencyName a;
            a = ConverterToCurrencyName.Convert("Є");
            Assert.AreEqual(a, CurrencyName.Euro);
        }

        [TestMethod]
        public void NoneTest()
        {
            CurrencyName a;
            a = ConverterToCurrencyName.Convert("юань");
            Assert.AreEqual(a, CurrencyName.None);
        }

        //Reading testing
        [TestMethod]
        public void ReadTest()
        {
            Currency curr = new Currency();
            List<Currency> lcur = new List<Currency>(), TestListCurr=new List<Currency>();
            curr.Read(lcur);
            TestListCurr.Add(new Currency(CurrencyName.UAH, 100));
            TestListCurr.Add(new Currency(CurrencyName.Euro, 200));
            TestListCurr.Add(new Currency(CurrencyName.UAH, 25000));
            TestListCurr.Add(new Currency(CurrencyName.Euro, 400));
            TestListCurr.Add(new Currency(CurrencyName.Dollar, 400));
            TestListCurr.Add(new Currency(CurrencyName.Dollar, 400));
            for (int i = 0; i < 4; ++i)
            {
                Assert.AreEqual(lcur[i].ToString(), TestListCurr[i].ToString());
            }
        }

        //ToString method test
        [TestMethod]
        public void ToStringTest()
        {
            Currency curr = new Currency(CurrencyName.Dollar, 100);
            string temp = "CurrencyName - Dollar\nAmount - 100";
            Assert.AreEqual(curr.ToString(), temp);
            curr = new Currency(CurrencyName.UAH, 100);
            temp = "CurrencyName - UAH\nAmount - 100";
            Assert.AreEqual(curr.ToString(), temp);
            curr = new Currency(CurrencyName.Euro, 100);
            temp = "CurrencyName - Euro\nAmount - 100";
            Assert.AreEqual(curr.ToString(), temp);
        }

        //Do pair test
        [TestMethod]
        public void DoPairTest()
        {
            Dictionary<CurrencyName, double> currencies = new Dictionary<CurrencyName, double>();
            List<Currency> CurrList = new List<Currency>();
            CurrList.Add(new Currency(CurrencyName.UAH, 500));
            CurrList.Add(new Currency(CurrencyName.UAH, 100));
            CurrList.Add(new Currency(CurrencyName.Dollar, 100));
            CurrList.Add(new Currency(CurrencyName.Euro, 200));
            CurrList.Add(new Currency(CurrencyName.Euro, 100));
            currencies = PairOfCurrency.DoPair(CurrList);
            foreach (var i in currencies)
            {
                if (i.Key == CurrencyName.UAH)
                {
                    Assert.AreEqual(i.Value, 600);
                }
                if (i.Key == CurrencyName.Dollar)
                {
                    Assert.AreEqual(i.Value, 100);
                }
                if (i.Key == CurrencyName.Euro)
                {
                    Assert.AreEqual(i.Value, 300);
                }
            }
        }


        //Next 3 - ConvertionTo test
        [TestMethod]
        public void ConvertToDollarTest()
        {
            Dictionary<CurrencyName, double> result = new Dictionary<CurrencyName, double>();
            Dictionary<CurrencyName, double> currencies = new Dictionary<CurrencyName, double>();
            List<Currency> list = new List<Currency>();
            list.Add(new Currency(CurrencyName.Euro, 100));
            list.Add(new Currency(CurrencyName.Euro, 200));
            list.Add(new Currency(CurrencyName.Dollar, 100));
            list.Add(new Currency(CurrencyName.UAH, 1000));
            list.Add(new Currency(CurrencyName.UAH, 100));
            list.Add(new Currency(CurrencyName.Dollar, 200));
            currencies = PairOfCurrency.DoPair(list);
            result = Conversion.To(currencies, CurrencyName.Dollar);
            foreach (var i in result)
            {
                Assert.AreEqual(i.Key, CurrencyName.Dollar);
                Assert.AreEqual(Math.Round(i.Value,2), 687.95);
            }
        }

        
        [TestMethod]
        public void ConvertToEuroTest()
        {
            Dictionary<CurrencyName, double> result = new Dictionary<CurrencyName, double>();
            Dictionary<CurrencyName, double> currencies = new Dictionary<CurrencyName, double>();
            List<Currency> list = new List<Currency>();
            list.Add(new Currency(CurrencyName.Euro, 100));
            list.Add(new Currency(CurrencyName.Euro, 200));
            list.Add(new Currency(CurrencyName.Dollar, 100));
            list.Add(new Currency(CurrencyName.UAH, 1000));
            list.Add(new Currency(CurrencyName.UAH, 100));
            list.Add(new Currency(CurrencyName.Dollar, 200));
            currencies = PairOfCurrency.DoPair(list);
            result = Conversion.To(currencies, CurrencyName.Euro);
            foreach (var i in result)
            {
                Assert.AreEqual(i.Key, CurrencyName.Euro);
                Assert.AreEqual(Math.Round(i.Value, 2), 591.62);
            }
        }

     
        [TestMethod]
        public void ConvertToHryvniaTest()
        {
            Dictionary<CurrencyName, double> result = new Dictionary<CurrencyName, double>();
            Dictionary<CurrencyName, double> currencies = new Dictionary<CurrencyName, double>();
            List<Currency> list = new List<Currency>();
            list.Add(new Currency(CurrencyName.Euro, 100));
            list.Add(new Currency(CurrencyName.Euro, 200));
            list.Add(new Currency(CurrencyName.Dollar, 100));
            list.Add(new Currency(CurrencyName.UAH, 1000));
            list.Add(new Currency(CurrencyName.UAH, 100));
            list.Add(new Currency(CurrencyName.Dollar, 200));
            currencies = PairOfCurrency.DoPair(list);
            result = Conversion.To(currencies, CurrencyName.UAH);
            foreach (var i in result)
            {
                Assert.AreEqual(i.Key, CurrencyName.UAH);
                Assert.AreEqual(Math.Round(i.Value, 2), 19352);
            }
        }

        [TestMethod]
        public void CalculateTest()
        {
            int sum = 10000;
            double DollarsSum = Math.Round(Conversion.Calculate(sum, UAH_VALUE, DOLLAR_VALUE), 2);
            Assert.AreEqual(DollarsSum, 355.49);
        }

    }
}
