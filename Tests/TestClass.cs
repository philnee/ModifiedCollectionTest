using ClassLibrary1;
using Xunit;

namespace Tests
{
    public class TestClass
    {
        [Fact]
        public void Test()
        {
            var class1 = new Class1();

            class1.Run();

            Assert.Equal(true,true);
        }
    }
}
