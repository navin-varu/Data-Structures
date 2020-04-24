using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Queues.OperationContracts;
namespace DataStructures.Queues.Abstracts
{
    public enum QueueBase
    {
        Array,
        CircularArray,
        LinkedList,
        Stack
    }
    public abstract class Queue : IQueueOperations
    {
        protected int front = -1;
        protected int rear = -1;
        public abstract int Size { get; }
        public abstract string QueueBaseType { get; }
        public abstract void Clear();
        public abstract string Dequeue();
        public abstract string Display();
        public abstract void Enqueue(string item);
        public abstract IEnumerator GetEnumerator();
        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract string Peak();
    }
}
