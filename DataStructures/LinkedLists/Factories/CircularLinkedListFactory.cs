using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Factories
{
    class CircularLinkedListFactory : ILinkedListFactory
    {
        public LinkedListType LinkedListType => LinkedListType.Circular;

        public LinkedList CreateLinkedList()
        {
            return new CircularLinkedList();
        }
    }
}
