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
        private SinglyLinkedList<Car> _anotherList;

        public UnitTestSinglyLinkedList()
        {
            _singlyLinkedListIntegers = new SinglyLinkedList<int>();
            _anotherList = new SinglyLinkedList<Car>();
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

        [TestMethod]
        public void add_two_cars_and_count()
        {
            // arrange
            _anotherList.AddHead(new Car { Make = "Toyota", Model = "4Runner" });
            _anotherList.AddTail(new Car { Make = "Toyota", Model = "Camry" });
            int _expected = 2;
            int _actual;

            // act
            _actual = _anotherList.Count;

            // assert
            Assert.AreEqual(_expected, _actual);
        
        }


        [TestMethod]
        public void add_two_cars_and_head_should_be_4runner()
        {
            // arrange
            _anotherList.AddHead(new Car { Make = "Toyota", Model = "4Runner" });
            _anotherList.AddTail(new Car { Make = "Toyota", Model = "Camry" });
            string _headModel = "4Runner";
            SinglyLinkedNode<Car> _actual = _anotherList.Head;

            // act
            
            // assert
            Assert.AreEqual(_headModel, _actual.Value.Model);

        }


        private class Car
        { 
            public string Make { get; set; }
            public string Model { get; set; }
        
        }

       
    }
}
