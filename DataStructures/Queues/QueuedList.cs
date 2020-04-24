using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Enumerators;
using DataStructures.LinkedLists.Factories;
using DataStructures.Queues.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue = DataStructures.Queues.Abstracts.Queue;

namespace DataStructures.Queues
{
    internal class QueuedList : Queue
    {
        private readonly string _queueBaseType = "LinkedList";
        private readonly int _size = 0;
        private LinkedList _queue;
        public override int Size => this._size;
        public override string QueueBaseType => this._queueBaseType;
        private QueuedList()
        {

        }

        public QueuedList(int size)
        {
            this._size = size;
            this._queue = LinkedListFactory.GetLinkedList(LinkedListType.Single);
        }
        public override void Clear()
        {
            this._queue.Clear();
        }

        public override string Dequeue()
        {
            string item = "";
            if (this._queue == null)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this._queue.IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else
            {
                item = this._queue.GetValueAt(1);
                this._queue.RemoveFirst();
            }
            return item;
        }

        public override string Display()
        {
            string queue = "";
            if (this._queue == null)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this._queue.IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else
            {
                queue = this._queue.Display();
            }
            return queue;
        }

        public override void Enqueue(string item)
        {
            if (this._queue == null)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this.IsFull())
            {
                throw new Exception(QueueCommon.OVER_FLOW);
            }
            else
            {
                this._queue.InsertLast(item);
            }
        }

        public override bool IsEmpty()
        {
            return this._queue.IsEmpty();
        }

        public override bool IsFull()
        {
            return (this._queue.GetLength() == this._size);
        }

        public override string Peak()
        {
            string item = "";
            if (this._queue == null)
            {
                throw new Exception(QueueCommon.NOT_INITIALIZED);
            }
            else if (this._queue.IsEmpty())
            {
                throw new Exception(QueueCommon.UNDER_FLOW);
            }
            else
            {
                item = this._queue.GetValueAt(1);
            }
            return item;
        }

        public override IEnumerator GetEnumerator()
        {
            return new LinkedListEnumerator(this._queue);
        }
    }
}
