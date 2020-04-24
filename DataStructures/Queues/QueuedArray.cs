using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Enumerators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue = DataStructures.Queues.Abstracts.Queue;

namespace DataStructures.Queues
{
    internal class QueuedArray : Queue
    {
        private readonly string _queueBaseType = "Array";
        private readonly int _size = 0;
        private string[] _queue;
        public override int Size => this._size;
        public override string QueueBaseType => this._queueBaseType;
        private QueuedArray()
        {

        }

        public QueuedArray(int size)
        {
            this.front = this.rear = -1;
            this._size = size;
            this._queue = new string[this._size];
        }

        public override void Clear()
        {
            this.front = this.rear = -1;
            this._queue = null;
            this._queue = new string[this._size];
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
                item = this._queue[this.front];
                this.front = this.rear = -1;
            }
            else
            {
                item = this._queue[this.front++];
            }
            return item;
        }

        public override string Display()
        {
            string queue = "";
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
                for (int i = this.front; i <= this.rear; i++)
                {
                    queue += this._queue[i];
                    queue += (i == this.rear) ? "." : "-->";
                }
            }
            return queue;
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
                this._queue[this.rear] = item;
            }
            else
            {
                this._queue[++this.rear] = item;
            }
        }

        public override bool IsEmpty()
        {
            return (this.front == -1 && this.rear == -1);
        }

        public override bool IsFull()
        {
            return (this.rear == this._size - 1);
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
                item = this._queue[this.front];
            }
            return item;
        }

        public override IEnumerator GetEnumerator()
        {
            return new QueueEnumerator(this._queue, this.front, this.rear, p => p++, (p, r) => p <= r);
        }
    }
}
