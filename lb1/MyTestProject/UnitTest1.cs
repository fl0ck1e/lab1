using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClass;

namespace MyTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 class1 = new Class1();
            int a = 12;
            int b = 999;
            int c = 543;
            int d = 432;

            string ea = "3, 2, 2, ";
            string eb = "37, 3, 3, 3, ";
            string ec = "181, 3, ";
            string ed = "3, 3, 3, 2, 2, 2, 2, ";


            string fa = class1.pf(a);
            string fb = class1.pf(b);
            string fc = class1.pf(c);
            string fd = class1.pf(d);

            Assert.AreEqual(ea, fa);
            Assert.AreEqual(eb, fb);
            Assert.AreEqual(ec, fc);
            Assert.AreEqual(ed, fd);
        }
    }
}