using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Factories
{
    class DoubleLinkedListFactory<T> : ILinkedListFactory<T>
    {
        public LinkedListType LinkedListType => LinkedListType.Double;

        public AbstarctLinkedList<T> CreateLinkedList()
        {
            return new DoubleLinkedList<T>();
        }
    }
}
