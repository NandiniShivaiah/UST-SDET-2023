namespace TestPro1
{

    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Init()
        {
            Console.WriteLine("Setup Method");
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2 Method");
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1 Method");
            Assert.AreEqual(1, 1);
        }

        [TearDown]
        public void Close()
        {
            Console.WriteLine("Close Method");
        }
    }
}