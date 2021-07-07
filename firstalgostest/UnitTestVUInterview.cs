using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using firstalgos;

namespace firstalgostest
{


    [TestClass]
    public class UnitTestVUInterview
    {

        [TestMethod]
        public void given_S_aabbb_the_function_should_return_true() 
        {

            // arrange
            VUInterview vu = new VUInterview();
            string value = "aabbbb";

            // act
            bool expected = true;
            bool actual = vu.CheckString(value);

            // assert
            Assert.AreEqual(expected, actual);
       
        }

        [TestMethod]
        public void given_S_null_the_function_should_return_true()
        {
            // arrange
            VUInterview vu = new VUInterview();
            string value = null;

            // act
            bool expected = false;
            bool actual = vu.CheckString(value);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void given_S_ba_the_function_should_return_false()
        {
            // arrange
            VUInterview vu = new VUInterview();
            string value = "ba";

            // act
            bool expected = false;
            bool actual = vu.CheckString(value);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void given_S_aaa_the_function_should_return_false()
        {
            // arrange
            VUInterview vu = new VUInterview();
            string value = "aaa";

            // act
            bool expected = true;
            bool actual = vu.CheckString(value);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void given_S_abba_the_function_should_return_false()
        {
            // arrange
            VUInterview vu = new VUInterview();
            string value = "abba";

            // act
            bool expected = false;
            bool actual = vu.CheckString(value);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void given_S_b_the_function_should_return_false()
        {
            // arrange
            VUInterview vu = new VUInterview();
            string value = "b";

            // act
            bool expected = true;
            bool actual = vu.CheckString(value);

            // assert
            Assert.AreEqual(expected, actual);
        }


    }
}
