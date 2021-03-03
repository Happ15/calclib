using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calclibtests
{
    [TestClass]
    public class calclibtest
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            calclib.Calc c = new calclib.Calc();

            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Proc_10and20_201returned()
        {
            int x = 10;
            int y = 20;
            int expected = 201;

            calclib.Calc c = new calclib.Calc();

            int actual = c.proc(x, y);

            Assert.AreEqual(expected, actual);

        }
    }
}
