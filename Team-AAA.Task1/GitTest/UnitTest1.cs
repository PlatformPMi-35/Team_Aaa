
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team_AAA.Task1;
using Team_AAA.Task1.Classes_and_interfaces;

namespace GitTest
{
    
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void HryvnaTest()
            {
            CurrencyName a;
            a = ConverterToCurrencyName.Convert("грн");
            Assert.AreEqual(a, CurrencyName.UAH);
            }
        public void DollarTest()
        {
            CurrencyName a;
            a = ConverterToCurrencyName.Convert("$");
            Assert.AreEqual(a, CurrencyName.Dollar);
        }
        public void EuroTest()
        {
            CurrencyName a;
            a = ConverterToCurrencyName.Convert("Є");
            Assert.AreEqual(a, CurrencyName.Euro);
        }
        public void NoneTest()
        {
            CurrencyName a;
            a = ConverterToCurrencyName.Convert("юань");
            Assert.AreEqual(a, CurrencyName.None);
        }
    }
    
}
