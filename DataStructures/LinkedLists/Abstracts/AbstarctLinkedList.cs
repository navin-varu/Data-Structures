using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LinkedLists.OperationContracts;

namespace DataStructures.LinkedLists.Abstracts
{
    public enum LinkedListType
    {
        Single,
        Circular,
        Double,
        DoubleCircular
    }

    /// <summary>
    /// Provides a base implementation for the extensible linked list model.
    /// </summary>
    public abstract class AbstarctLinkedList<T> : ILinkedListOperations<T>
    {
        internal int Length = 0;
        public abstract string LinkedListName { get; }
        public abstract void Clear();
        public abstract void Create(T[] values);
        public abstract IEnumerator GetEnumerator();
        public abstract int GetLength();
        public abstract T GetValueAt(int index);
        public abstract void InsertAt(int index, T value);
        public abstract void InsertFirst(T value);
        public abstract void InsertLast(T value);
        public abstract bool IsEmpty();
        public abstract void RemoveAt(int index);
        public abstract void RemoveFirst();
        public abstract void RemoveLast();
        public abstract void Reverse();
    }
}
