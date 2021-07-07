using Microsoft.VisualStudio.TestTools.UnitTesting;
using firstalgos;
using BinaryGap;

namespace firstalgostest
{
    [TestClass]
    public class UnitTestBinaryGap
    {
        private Solution1 _s;
        
        public UnitTestBinaryGap() 
        {
            _s = new Solution1();
        }

        [TestMethod]
        public void pass_in_4_should_return_0()
        {

            // arrange
            int expected = 0;
            int actual;

            // act
            actual = _s.BinaryGapAnswerOne(4);

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
            actual = _s.BinaryGapAnswerOne(value);

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
            actual = _s.BinaryGapAnswerOne(value);

            // assert
            Assert.AreEqual(expected, actual);

        }

    }
}
