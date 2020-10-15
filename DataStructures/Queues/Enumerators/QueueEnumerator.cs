using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Enumerators
{
    internal class QueueEnumerator<T> : IEnumerator
    {
        private readonly T[] _queue;
        private int _front = 0, _rear = 0;
        private int _position;
        private Func<int, int> _incrementer;
        private Func<int, int, bool> _condition;
        internal QueueEnumerator(T[] queue, int front, int rear
            , Func<int, int> incrementer, Func<int, int, bool> condition)
        {
            this._queue = queue;
            this._front = front;
            this._rear = rear;
            this._position = this._front - 1;
            this._incrementer = incrementer;
            this._condition = condition;
        }
        public object Current
        {
            get
            {
                return this._queue[this._position];
            }
        }

        public bool MoveNext()
        {
            this._position = this._incrementer(this._position);
            return this._condition(this._position, this._rear);
        }

        public void Reset()
        {
            this._position = this._front - 1;
        }
    }
}
