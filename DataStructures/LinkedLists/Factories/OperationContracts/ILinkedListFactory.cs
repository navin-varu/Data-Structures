using System;
using System.Text;
using DataStructures.LinkedLists.Abstracts;

namespace DataStructures.LinkedLists.Factories.OperationContracts
{
    public interface ILinkedListFactory<T>: ILinkedListFactory
    {
        LinkedListType LinkedListType { get; }
        AbstractLinkedList<T> CreateLinkedList();
    }

    public interface ILinkedListFactory
    {
      
    }
}
