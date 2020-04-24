using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Factories
{
    class SingleLinkedListFactory : ILinkedListFactory
    {
        public LinkedListType LinkedListType => LinkedListType.Single;

        public LinkedList CreateLinkedList()
        {
            return new SingleLinkedList();
        }
    }
}
