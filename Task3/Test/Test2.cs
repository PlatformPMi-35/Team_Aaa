namespace Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Task3;
    using Task3.Classes;
    /// <summary>
    /// Collection of Sushi class test
    /// </summary>
    [TestClass]
    public class Test1
    {
        CollectionOfShushi collection = new CollectionOfShushi();

        [TestMethod]
        public void ReadTest()
        {
            collection.Read(@"C:\Users\Home\Desktop\C#\WPF\Team_Aaa\Task3\Test\data.txt");
            Sushi a = new Sushi("sushi", 1, 1,"1");
            Assert.AreEqual(collection.list[0].ToString(), a.ToString());
            a = new Sushi("AnotherSushi", 2, 2, "2");
            Assert.AreEqual(collection.list[1].ToString(), a.ToString());
        }

        [TestMethod]
        public void AddTest()
        {
            CollectionOfShushi c = new CollectionOfShushi();
            Sushi a = new Sushi("hz", 1, 1, "1");
            c.Add(a);
            Assert.AreEqual(c.list.Count, 1);
        }

        [TestMethod]
        public void DeleteTest()
        {
            collection.list.Clear();
            collection.Read(@"C:\Users\Home\Desktop\C#\WPF\Team_Aaa\Task3\Test\data.txt");
            collection.DeleteByName("sushi");
            Assert.AreEqual(collection.list[0].ToString(), new Sushi("AnotherSushi", 2, 2, "2").ToString());
        }

        [TestMethod]
        public void GetListTest()
        {
            List<Sushi> l = new List<Sushi>();
            collection.list.Clear();
            collection.Read(@"C:\Users\Home\Desktop\C#\WPF\Team_Aaa\Task3\Test\data.txt");
            Sushi a = new Sushi("sushi", 1, 1, "1");
            l.Add(a);
            Sushi b = new Sushi("AnotherSushi", 2, 2, "2");
            l.Add(b);
            Assert.AreEqual(l[0].ToString(), new Sushi("sushi",1,1,"1").ToString());
            Assert.AreEqual(l[1].ToString(), new Sushi("AnotherSushi", 2, 2, "2").ToString());
        }
    }
}
