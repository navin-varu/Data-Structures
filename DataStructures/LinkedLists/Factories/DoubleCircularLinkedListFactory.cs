using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Factories
{
    class DoubleCircularLinkedListFactory : ILinkedListFactory
    {
        public LinkedListType LinkedListType => LinkedListType.DoubleCircular;

        public LinkedList CreateLinkedList()
        {
            return new DoubleCircularLinkedList();
        }
    }
}
