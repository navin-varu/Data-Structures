using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Factories
{
    class DoubleCircularLinkedListFactory<T> : ILinkedListFactory<T>
    {
        public LinkedListType LinkedListType => LinkedListType.DoubleCircular;

        public AbstarctLinkedList<T> CreateLinkedList()
        {
            return new DoubleCircularLinkedList<T>();
        }
    }
}
