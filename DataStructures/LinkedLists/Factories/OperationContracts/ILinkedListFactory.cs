using System;
using System.Text;
using DataStructures.LinkedLists.Abstracts;

namespace DataStructures.LinkedLists.Factories.OperationContracts
{
    public interface ILinkedListFactory
    {
        LinkedListType LinkedListType { get; }
        LinkedList CreateLinkedList();
    }
}
