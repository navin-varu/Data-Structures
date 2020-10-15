using System;
using System.Text;
using DataStructures.LinkedLists.Abstracts;

namespace DataStructures.LinkedLists.Factories.OperationContracts
{
    public interface ILinkedListFactory<T>
    {
        LinkedListType LinkedListType { get; }
        AbstarctLinkedList<T> CreateLinkedList();
    }
}
