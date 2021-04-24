using NUnit.Framework;
using chapter5;

namespace NUnitTestChapter5
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInsertNumbFotBits()
        {
            bits b = new bits();
            int res = b.insertNumb(23, 100, 3, 2);
            Assert.AreEqual(0, res);
            res = b.insertNumb(23, 100, 7, 2);
            //Assert.AreEqual(0, res);
        }
    }
}