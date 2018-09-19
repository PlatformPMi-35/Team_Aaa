using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team_AAA.Task1;
using Team_AAA.Task1.Classes_and_interfaces;

namespace GitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Currency name convertion tests
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
        }

        //Convertion to test
        [TestMethod]
        public void ConvertionToTest()
        {

        }
    }
}
