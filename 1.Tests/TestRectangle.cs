using NUnit.Framework;
using _1;

namespace _1.Tests
{
    public class TestRectangle
    {
        Rectangle r = new Rectangle(2, 4);

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSquare()
        {
            Assert.AreEqual(r.Square(), 8);
        }

        [Test]
        public void TestPerimeter()
        {
            Assert.AreEqual(r.Perimeter(), 12);
        }
    }
}