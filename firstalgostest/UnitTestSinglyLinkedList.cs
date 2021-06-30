using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace firstalgostest
{

    [TestClass]
    public class UnitTestSinglyLinkedList
    {

        private SinglyLinkedList<int> _singlyLinkedListIntegers;

        public UnitTestSinglyLinkedList()
        {

            _singlyLinkedListIntegers = new SinglyLinkedList<int>();
        }

        [TestMethod]
        public void add_three_node_and_count()
        {
            // arrange
            int _actual = 0;
            int _expected = 3;

            // act
            _singlyLinkedListIntegers.AddHead(100);
            _singlyLinkedListIntegers.AddHead(200);
            _singlyLinkedListIntegers.AddHead(300); // 300,200,100
            _actual = _singlyLinkedListIntegers.Count;

            // assert
            Assert.AreEqual(_expected, _singlyLinkedListIntegers.Count);
        
        }
    }
}
