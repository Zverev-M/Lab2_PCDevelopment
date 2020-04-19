using NUnit.Framework;
using _1;

namespace _1.Tests
{
    public class TestTriangle
    {
        Triangle t = new Triangle(1, 2, 3);

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPerimeter()
        {
            Assert.AreEqual(t.Perimeter(), 6);
        }
    }
}