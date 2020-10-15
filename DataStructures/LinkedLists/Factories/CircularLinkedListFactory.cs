using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Factories
{
    class CircularLinkedListFactory<T> : ILinkedListFactory<T>
    {
        public LinkedListType LinkedListType => LinkedListType.Circular;

        public AbstarctLinkedList<T> CreateLinkedList()
        {
            return new CircularLinkedList<T>();
        }
    }
}
