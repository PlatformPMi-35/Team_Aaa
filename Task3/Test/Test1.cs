namespace Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Task3;
    using Task3.Classes;
    /// <summary>
    /// Sushi class test
    /// </summary>
    [TestClass]
    public class Test2
    {
        Sushi a = new Sushi("New sushi", 322, 102, "Fish");
        Sushi b = new Sushi();
        [TestMethod]
        public void SushiToString()
        {
            string test = a.ToString();
            string ex = "New sushi 322 uah 102 g Fish";
            Assert.AreEqual(test, ex);
        }

        [TestMethod]
        public void SushiForList()
        {
            string test = a.ForList;
            string ex = "New sushi 322 uah";
            Assert.AreEqual(test, ex);
        }

        [TestMethod]
        public void SushiIsGood()
        {
            Assert.AreEqual(a.isGood(), true);
            Assert.AreEqual(b.isGood(), false);
        }
    }
}
