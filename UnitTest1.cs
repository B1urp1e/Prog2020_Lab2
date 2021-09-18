using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Triangle_lab2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPythagorus()
        {
            PythagTest obj = new PythagTest();
            double result = obj.MissingSide(5, 10);
            Assert.AreEqual(result, Math.Sqrt(125));
        }
        [TestMethod]
        public void TestAngles()
        {
            PythagTest obj = new PythagTest();
            int result = obj.MissingAngle(34, 62);
            Assert.AreEqual(result, 84);
        }

        [TestMethod]
        public void TestArea()
        {
            PythagTest obj = new PythagTest();
            double result = obj.Area(12, 9);
            Assert.AreEqual(result, (0.5 * (12 * 9)));
        }

    }
}
