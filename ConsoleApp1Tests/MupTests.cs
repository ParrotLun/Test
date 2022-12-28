using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tests
{
    [TestClass()]
    public class MupTests
    {
        [TestMethod()]
        public void mutiplTest()
        {
            string[] args = { "8", "7" };
            int result = ConsoleApp.Mup.mutipl(args);

            Assert.AreEqual(result,56);
        }
        [TestMethod()]
        public void GG()
        {
            string[] args = { "9", "7" };
            int result = ConsoleApp.Mup.mutipl(args);

            Assert.AreEqual(result, 63);
        }
    }
}