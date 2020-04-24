using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Factories
{
    class DoubleLinkedListFactory : ILinkedListFactory
    {
        public LinkedListType LinkedListType => LinkedListType.Double;

        public LinkedList CreateLinkedList()
        {
            return new DoubleLinkedList();
        }
    }
}
