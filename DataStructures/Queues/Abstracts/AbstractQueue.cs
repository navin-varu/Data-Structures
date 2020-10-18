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
    public abstract class AbstractQueue<T> : IQueueOperations<T>
    {
        protected int front = -1;
        protected int rear = -1;
        public abstract int Size { get; }
        public abstract string QueueBaseType { get; }
        public abstract void Clear();
        public abstract T Dequeue();
        public abstract void Enqueue(T item);
        public abstract IEnumerator<T> GetEnumerator();
        public abstract bool IsEmpty();
        public abstract bool IsFull();
        public abstract T Peak();

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
