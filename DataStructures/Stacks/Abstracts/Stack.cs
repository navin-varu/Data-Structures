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
    public abstract class Stack : IStackOperations
    {
        protected int top = -1;
        public abstract int Size { get; }
        public abstract string StackBaseType { get; }
        public abstract void Clear();
        public abstract string Display();
        public abstract IEnumerator GetEnumerator();
        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract string Peak();
        public abstract string Pop();
        public abstract void Push(string item);
    }
}
