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
        public void TestInsertNumbForBits()
        {
            bits b = new bits();
            int res = b.insertNumb(23, 100, 3, 2);
            Assert.AreEqual(0, res);
            res = b.insertNumb(23, 100, 7, 2);
            Assert.AreEqual(92, res);
            res = b.insertNumb(56, 245, 7, 2);
            Assert.AreEqual(225, res);
        }
        [Test]
        public void TestConvertIntoBinbForBits()
        {
            bits b = new bits();
            string res = b.convertIntoBin(0.54);
            Assert.AreEqual("100010100011110101110000101000111", res);
            res = b.convertIntoBin(0.657); 
            Assert.AreEqual("101010000011000100100110111010010", res);
        }
    }
}