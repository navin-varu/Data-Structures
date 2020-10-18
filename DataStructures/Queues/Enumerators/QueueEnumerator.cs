using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Enumerators
{
    internal class QueueEnumerator<T> : IEnumerator<T>
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
        public T Current
        {
            get
            {
                return this._queue[this._position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            this._position = this._incrementer(this._position);
            return this._condition(this._position, this._rear);
        }

        public void Reset()
        {
            this._position = this._front - 1;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~QueueEnumerator()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
