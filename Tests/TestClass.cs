using ClassLibrary1;
using NUnit.Framework;

namespace Tests
{
    public class TestClass
    {
        [Test]
        public void Test()
        {
            var class1 = new Class1();

            class1.Run();

            Assert.AreEqual(true,true);
        }
    }
}
