using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Enumerators;
using DataStructures.LinkedLists.Factories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.LinkedLists
{
    public static class SingleLinkedListTests
    {
        [Test]
        public static void ClearQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            linkedList.Create(new int[10]
            {
                1,2,3,4,5,6,7,8,9,0
            });

            // Act
            linkedList.Clear();

            // Assert
            Assert.IsTrue(linkedList.IsEmpty(), "Linked List is empty");
        }

        [Test]
        public static void IsEmptyQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            linkedList.Create(new int[10]
            {
                1,2,3,4,5,6,7,8,9,0
            });

            // Act
            linkedList.Clear();

            // Assert
            Assert.IsTrue(linkedList.IsEmpty(), "Linked List is empty");
        }

        [Test]
        public static void InsertFirstQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.InsertFirst(1);

            // Assert
            Assert.AreEqual(expected: 1, actual: linkedList.GetValueAt(1));
            Assert.AreEqual(expected: 1, actual: linkedList.GetLength());
        }

        [Test]
        public static void InsertLastQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.InsertFirst(1);

            // Assert
            Assert.AreEqual(expected: 1, actual: linkedList.GetValueAt(1));
            Assert.AreEqual(expected: 1, actual: linkedList.GetLength());
        }

        [Test]
        public static void InsertAtQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            linkedList.InsertAt(3, -1);

            // Assert
            Assert.AreEqual(expected: -1, actual: linkedList.GetValueAt(3));
            Assert.AreEqual(expected: 6, actual: linkedList.GetLength());
        }

        [Test]
        public static void RemoveFirstQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            linkedList.RemoveFirst();

            // Assert
            Assert.AreNotEqual(expected: 1, actual: linkedList.GetValueAt(1));
            Assert.AreEqual(expected: 4, actual: linkedList.GetLength());
        }

        [Test]
        public static void RemoveLastQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            linkedList.RemoveLast();

            // Assert
            int length = linkedList.GetLength();
            Assert.AreNotEqual(expected: 5, actual: linkedList.GetValueAt(length));
            Assert.AreEqual(expected: 4, actual: linkedList.GetLength());
        }

        [Test]
        public static void RemoveAtQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            linkedList.RemoveAt(2);

            // Assert
            Assert.AreNotEqual(expected: 3, actual: linkedList.GetValueAt(3));
            Assert.AreEqual(expected: 4, actual: linkedList.GetLength());
        }

        [Test]
        public static void ReverseQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            linkedList.Reverse();

            // Assert
            Assert.AreEqual(expected: 5, actual: linkedList.GetValueAt(1));
            Assert.AreEqual(expected: 5, actual: linkedList.GetLength());
        }

        [Test]
        public static void CreateQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            // Assert
            Assert.AreEqual(expected: 1, actual: linkedList.GetValueAt(1));
            Assert.AreEqual(expected: 5, actual: linkedList.GetLength());
        }

        [Test]
        public static void GetLengthQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            // Assert
            Assert.AreEqual(expected: 5, actual: linkedList.GetLength());
        }

        [Test]
        public static void GetValueAtQualityTests()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            // Assert
            Assert.AreEqual(expected: 3, actual: linkedList.GetValueAt(3));
        }

        [Test]
        public static void GetEnumeratorTypeQualityTest()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            var enumeratorActual = linkedList.GetEnumerator();

            // Assert
            Assert.AreEqual(expected: typeof(LinkedListEnumerator<int>), actual: enumeratorActual?.GetType());
        }

        [Test]
        public static void GetEnumeratorItemQualityTest()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            var enumeratorActual = linkedList.GetEnumerator();

            int firstvalue = 0;

            if (enumeratorActual.MoveNext())
            {
                firstvalue = enumeratorActual.Current;
            }

            // Assert
            Assert.AreEqual(expected: typeof(int), actual: firstvalue.GetType());
            Assert.AreEqual(expected: 1, actual: firstvalue);
        }

        [Test]
        public static void GetEnumeratorItemsListQualityTest()
        {
            // Arrange
            var factory = LinkedListFactory<int>.GetFactory.Load(LinkedListType.Single);
            var linkedList = factory.CreateLinkedList();

            // Act
            linkedList.Create(new int[5]
            {
                1,2,3,4,5
            });

            var enumeratorActual = linkedList.GetEnumerator();

            int sumOfItems = 0;

            while (enumeratorActual.MoveNext())
            {
                sumOfItems += enumeratorActual.Current;
            }

            // Assert
            Assert.AreEqual(expected: 15, actual: sumOfItems);
        }
    }
}
