using NUnit.Framework;

namespace Selenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Hello World");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();

        }


        [Test]
        public void Test2()
        {
            Assert.Pass();
        }
    }
}