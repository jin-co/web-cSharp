using NUnit.Framework;

namespace Assignment_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Set up");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}