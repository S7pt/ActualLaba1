using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LabaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 550;
            int result = ConsoleApp2.Program.Counter(a);
            Assert.AreEqual(9, result);
        }
    }
}
