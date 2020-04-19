using NUnit.Framework;
using _1;

namespace _1.Tests
{
    public class TestCircle
    {
        Circle c = new Circle(5);

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDiameter()
        {
            Assert.AreEqual(c.Diameter(), 10);
        }

        [Test]
        public void TestSquare()
        {
            bool p = false;
            if (c.Square() - 78.5 < 0.0001)
                p = true;
            Assert.AreEqual(true, p);
        }

        [Test]
        public void TestLenght()
        {
            bool p = false;
            if (c.Lenght() - 31.4 < 0.0001)
                p = true;

            Assert.AreEqual(true, p);
        }
    }
}