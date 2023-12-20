using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GrigorevKU.Sprint7.Project.V4.Lib;
namespace Tyuiu.GrigorevKU.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetBase()
        {
            DataService ds = new DataService();
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\testfile.csv";
            string[,] res = ds.GetBase(pathSaveFile);
            string[,] wait = { { "value1", "value2" }, { "value3", "value4" } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
