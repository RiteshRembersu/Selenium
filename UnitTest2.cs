using NUnit.Framework;

namespace Selenium
{
    public class Tests2
    {
        [SetUp]
        public void Setup()
        {
            System.Console.WriteLine("Hello for Changes");

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