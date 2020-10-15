using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Stacks.OperationContracts;

namespace DataStructures.Stacks.Abstracts
{
    public enum StackBase
    {
        Array,
        LinkedList
    }
    public abstract class AbstractStack<T> : IStackOperations<T>
    {
        protected int top = -1;
        public abstract int Size { get; }
        public abstract string StackBaseType { get; }
        public abstract void Clear();
        public abstract IEnumerator GetEnumerator();
        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract T Peak();
        public abstract T Pop();
        public abstract void Push(T item);
    }
}
