using Microsoft.VisualStudio.TestTools.UnitTesting;
using firstalgos;
using BinaryGap;

namespace firstalgostest
{
    [TestClass]
    public class UnitTestBinaryGap
    {
        private Gap _s;
        private SimplerGap _m;
        
        public UnitTestBinaryGap() 
        {
            _s = new Gap();
            _m = new SimplerGap();
        }


        [TestMethod]
        public void pass_in_0_should_return_0()
        {
            // 4 = 0100
            // arrange
            int expected = 0;
            int actual;

            // act
            actual = _s.BinaryGapConvert(0);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void pass_in_0_should_return_0_MySolution()
        {
            // 4 = 0100
            // arrange
            int expected = 0;
            int actual;

            // act
            actual = _m.BinaryGapConvert(0);

            // assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void pass_in_4_should_return_0()
        {
             // 4 = 0100
            // arrange
            int expected = 0;
            int actual;

            // act
            actual = _s.BinaryGapConvert(4);

            // assert
            Assert.AreEqual(expected, actual);
        
        }



        [TestMethod]
        public void pass_in_1000_should_return_1()
        {

            // arrange
            int value = 1000;
            int expected = 1;
            int actual;

            // act
            actual = _s.BinaryGapConvert(value);

            // assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void pass_in_million_should_return_4()
        {

            // arrange
            int value = 1000000; // 11110 100001 001000000
            int expected = 4;
            int actual;

            // act
            actual = _s.BinaryGapConvert(value);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void pass_in_9_should_return_2()
        {

            // arrange
            int value = 9; // 1001
            int expected = 2;
            int actual;

            // act
            actual = _s.BinaryGapConvert(value);

            // assert
            Assert.AreEqual(expected, actual);

        }

    }
}
