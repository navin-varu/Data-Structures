using DataStructures.Queues.Abstracts;
using DataStructures.Stacks.Abstracts;
using DataStructures.Stacks.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues
{
    internal class QueuedStack<T> : AbstractQueue<T>
    {
        private readonly string _queueBaseType = "Stack";
        private readonly int _size = 0;
        private AbstractStack<T> _enqueueStack;
        private AbstractStack<T> _dequeueStack;
        public override int Size => this._size;
        public override string QueueBaseType => this._queueBaseType;
        private QueuedStack()
        {

        }
        public QueuedStack(int size)
        {
            this._size = size;
            this._enqueueStack = StackFactory<T>.GetStack(StackBase.Array, size);
            this._dequeueStack = StackFactory<T>.GetStack(StackBase.Array, size);
        }
        public override void Clear()
        {
            this._enqueueStack.Clear();
            this._dequeueStack.Clear();
        }

        public override T Dequeue()
        {
            T item;
            if (this._enqueueStack == null || this._dequeueStack == null)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else
            {
                CopyStack(_enqueueStack, _dequeueStack);
                item = _dequeueStack.Pop();
                CopyStack(_dequeueStack, _enqueueStack);
            }
            return item;
        }

        
        public override void Enqueue(T item)
        {
            if (this._enqueueStack == null)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (IsFull())
            {
                throw new Exception(QueueCommon.OVER_FLOW);
            }
            else
            {
                this._enqueueStack.Push(item);
            }
        }

        public override bool IsEmpty()
        {
            return (this._enqueueStack.IsEmpty() && this._dequeueStack.IsEmpty());
        }

        public override bool IsFull()
        {
            return this._enqueueStack.IsFull();
        }

        public override T Peak()
        {
            T item;
            if (this._enqueueStack == null || this._dequeueStack == null)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else
            {
                CopyStack(_enqueueStack, _dequeueStack);
                item = _dequeueStack.Peak();
                CopyStack(_dequeueStack, _enqueueStack);
            }
            return item;
        }

        private void CopyStack(AbstractStack<T> source,AbstractStack<T> target)
        {
            while (!source.IsEmpty())
            {
                target.Push(source.Pop());
            }
        }

        public override IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
