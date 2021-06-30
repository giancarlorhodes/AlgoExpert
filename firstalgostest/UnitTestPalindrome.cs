using Microsoft.VisualStudio.TestTools.UnitTesting;
using firstalgos;

namespace firstalgostest
{
    [TestClass]
    public class UnitTestPalindrome
    {       
        private IPalindrome _p { get; set; }
        
        public UnitTestPalindrome() 
        {
            _p = new Palindrome();
        }

        [TestMethod]
        public void pass_null()
        {

            // arrange
            string _testThis = null;
            bool _expected = true;
            bool _actual;

            // act
            _actual = _p.TestForPalindromeless(_testThis);

            // assert
            Assert.AreEqual(_expected, _actual);

        }

        [TestMethod]
        public void empty_string() 
        {
            // arrange
            var _testThis = "";
            bool _expected = true;
            bool _actual;

            // act
            _actual = _p.TestForPalindromeless(_testThis);

            // assert
            Assert.AreEqual(_expected, _actual);
        }

        [TestMethod]
        public void one_char_only() 
        {

            // arrange
            var _testThis = "c";
            bool _expected = true;
            bool _actual;

            // act
            _actual = _p.TestForPalindromeless(_testThis);

            // assert
            Assert.AreEqual(_expected, _actual);

        }

        [TestMethod]
        public void two_char()
        {

            // arrange
            var _testThis = "ca";
            bool _expected = true;
            bool _actual;

            // act
            _actual = _p.TestForPalindromeless(_testThis);

            // assert
            Assert.AreEqual(_expected, _actual);

        }

        [TestMethod]
        public void three_char_palindrome()
        {

            // arrange
            var _testThis = "cac";
            bool _expected = true;
            bool _actual;

            // act
            _actual = _p.TestForPalindromeless(_testThis);

            // assert
            Assert.AreEqual(_expected, _actual);

        }

       

         [TestMethod]
        public void three_char_palindrome_false()
        {
            // arrange
            var _testThis = "cat";
            bool _expected = false;
            bool _actual;

            // act
            _actual = _p.TestForPalindromeless(_testThis);

            // assert
            Assert.AreEqual(_expected, _actual);

        }

        [TestMethod]
        public void four_char_palindrome()
        {
            // arrange
            var _testThis = "cttc";
            bool _expected = true;
            bool _actual;

            // act
            _actual = _p.TestForPalindromeless(_testThis);

            // assert
            Assert.AreEqual(_expected, _actual);

        }


        [TestMethod]
        public void five_char_palindrome()
        {
            // arrange
            var _testThis = "raxar";
            bool _expected = true;
            bool _actual;

            // act
            _actual = _p.TestForPalindromeless(_testThis);

            // assert
            Assert.AreEqual(_expected, _actual);

        }

        [TestMethod]
        public void five_char_palindrome_false()
        {
            // arrange
            var _testThis = "rader";
            bool _expected = false;
            bool _actual;

            // act
            _actual = _p.TestForPalindromeless(_testThis);

            // assert
            Assert.AreEqual(_expected, _actual);

        }



    }
}
