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
        [Test]
        public void TestCountBitsForBits()
        {
            bits b = new bits();
            int res = b.countBits(209);
            Assert.AreEqual(4, res);
            res = b.countBits(23436755);
            Assert.AreEqual(7, res);
            res = b.countBits(1775);
            Assert.AreEqual(8, res);
            res = b.countBits(0);
            Assert.AreEqual(1, res);
            res = b.countBits(-63);
            Assert.AreEqual(27, res);
        }
        [Test]
        public void TestCountBitsOpimisedForBits()
        {
            bits b = new bits();
            int res = b.countBitsOpimised(209);
            Assert.AreEqual(4, res);
            res = b.countBitsOpimised(23436755);
            Assert.AreEqual(7, res);
            res = b.countBitsOpimised(1775);
            Assert.AreEqual(8, res);
            res = b.countBitsOpimised(0);
            Assert.AreEqual(1, res); 
        }
        [Test]
        public void TestFindMaxAndMinForBits()
        {
            bits b = new bits();
            int max = 0;
            int min = 0;
            b.findMaxAndMin(910, ref max, ref min);
            Assert.AreEqual(918, max);
            Assert.AreEqual(909, min);
            b.findMaxAndMin(57939, ref max, ref min);
            Assert.AreEqual(57941, max);
            Assert.AreEqual(57931, min);
            b.findMaxAndMin(1, ref max, ref min);
            Assert.AreEqual(1, max);
            Assert.AreEqual(1, min);
            b.findMaxAndMin(1073741824, ref max, ref min);
            Assert.AreEqual(1073741824, max);
            Assert.AreEqual(536870912, min);
            b.findMaxAndMin(180765151, ref max, ref min);
            Assert.AreEqual(180765167, max);
            Assert.AreEqual(180765119, min);
        }
        [Test]
        public void TestChageBitsPlacementForBits()
        {
            bits b = new bits();
            int res = 0;
            res = b.chageBitsPlacement(213);
            Assert.AreEqual(234,res);

            res = b.chageBitsPlacement(31546);
            Assert.AreEqual(46901, res);//1011 0111 0011 0101
        }
        [Test]
        public void TestChageBitsPlacementEasyForBits()
        {
            bits b = new bits();
            int res = 0;
            res = b.chageBitsPlacementEasy(213);
            Assert.AreEqual(234, res);

            res = b.chageBitsPlacementEasy(31546);
            Assert.AreEqual(46901, res);//1011 0111 0011 0101
        }
    }
}