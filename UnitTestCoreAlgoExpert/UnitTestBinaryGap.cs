using BinaryGap;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCoreAlgoExpert
{
    [TestClass]
    public class UnitTestBinaryGap
    {
        [TestMethod]
        public void Gap_9_Is_1001_Should_Return_2()
        {
            // arrange
            Gap g = new Gap(); // core to core ???

            // act
            int _actual = g.BinaryGapConvert(9);
            int _expected = 2;

            // assert
            Assert.AreEqual(_expected, _actual);

        }


        [TestMethod]

        // The number 529 has binary representation 1000010001 and 
        // contains two binary gaps: one of length 4 and one of length 3
        public void Gap_529_Is_1000010001_Should_Return_4()
        {
            // arrange
            Gap g = new Gap();

            // act
            int _actual = g.BinaryGapConvert(529);
            int _expected = 4;

            // assert
            Assert.AreEqual(_expected, _actual);

        }


        [TestMethod]
        //The number 15 has binary representation 1111 and has no binary gaps.
        public void Gap_15_Is_1111_Should_Return_0()
        {
            //  arrange
            Gap g = new Gap();

            // act
            int _actual = g.BinaryGapConvert(15);
            int _expected = 0;

            // assert
            Assert.AreEqual(_expected, _actual);
        }


        // The number 20
        // has binary representation 10100 and contains one binary gap of length 1. 
        [TestMethod]       
        public void Gap_20_Is_10100_Should_Return_1() 
        {

            //  arrange
            Gap g = new Gap();

            // act
            int _actual = g.BinaryGapConvert(20);
            int _expected = 1;

            // assert
            Assert.AreEqual(_expected, _actual);

        }

        //The number
        // 32 has binary representation 100000 and has no binary gaps.
        [TestMethod]
        public void Gap_32_Is_10000_Should_Return_0()
        {

            //  arrange
            Gap g = new Gap();

            // act
            int _actual = g.BinaryGapConvert(32);
            int _expected = 0;

            // assert
            Assert.AreEqual(_expected, _actual);

        }

    }
}
