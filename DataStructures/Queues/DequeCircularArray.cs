using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Enumerators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues
{
    internal class DequeCircularArray : Deque
    {
        private readonly string _dequeBaseType = "CircularArray";
        private readonly int _size = 0;
        private string[] _deque;
        public override int Size => this._size;
        public override string QueueBaseType => this._dequeBaseType;
        private DequeCircularArray()
        {

        }

        public DequeCircularArray(int size)
        {
            this.front = this.rear = -1;
            this._size = size;
            this._deque = new string[this._size];
        }

        public override void Clear()
        {
            this.front = this.rear = -1;
            this._deque = null;
            this._deque = new string[this._size];
        }

        public override string Dequeue()
        {
            string item = "";
            if (this._size == 0)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this.IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else if (this.front == this.rear)
            {
                item = this._deque[this.front];
                this.front = this.rear = -1;
            }
            else
            {
                item = this._deque[this.front];
                this.front = (this.front + 1) % this._size;
            }
            return item;
        }

        public override string DequeueRear()
        {
            string item = "";
            if (this._size == 0)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this.IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else if (this.front == this.rear)
            {
                item = this._deque[this.rear];
                this.front = this.rear = -1;
            }
            else if (this.rear == 0)
            {
                item = this._deque[this.rear];
                this.rear = this._size - 1;
            }
            else
            {
                item = this._deque[this.rear];
                this.rear--;
            }
            return item;
        }

        public override string Display()
        {
            string deque = "";
            if (this._size == 0)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this.IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else
            {
                for (int i = this.front; i != this.rear; i = (i + 1) % this._size)
                {
                    deque += this._deque[i];
                    deque += (i == this.rear) ? "." : "-->";
                }
            }
            return deque;
        }

        public override void Enqueue(string item)
        {
            if (this._size == 0)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this.IsFull())
            {
                throw new Exception(QueueCommon.OVER_FLOW);
            }
            else if (this.IsEmpty())
            {
                this.front = this.rear = 0;
                this._deque[this.rear] = item;
            }
            else
            {
                this.rear = (this.rear + 1) % this._size;
                this._deque[this.rear] = item;
            }
        }

        public override void EnqueueFront(string item)
        {
            if (this._size == 0)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this.IsFull())
            {
                throw new Exception(QueueCommon.OVER_FLOW);
            }
            else if (this.IsEmpty())
            {
                this.front = this.rear = 0;
                this._deque[this.front] = item;
            }
            else if (this.front == 0)
            {
                this.front = this._size - 1;
                this._deque[this.front] = item;
            }
            else
            {
                this.front--;
                this._deque[this.front] = item;
            }
        }

        public override bool IsEmpty()
        {
            return (this.front == -1 && this.rear == -1);
        }

        public override bool IsFull()
        {
            return (this.front == ((this.rear + 1) % this._size));
        }

        public override string Peak()
        {
            string item = "";
            if (this._size == 0)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this.IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else
            {
                item = this._deque[this.front];
            }
            return item;
        }

        public override string PeakRear()
        {
            string item = "";
            if (this._size == 0)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this.IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else
            {
                item = this._deque[this.rear];
            }
            return item;
        }

        public override IEnumerator GetEnumerator()
        {
            return new QueueEnumerator(this._deque, this.front, this.rear, p => (p + 1) % this._size, (p, r) => p != r);
        }
    }
}
