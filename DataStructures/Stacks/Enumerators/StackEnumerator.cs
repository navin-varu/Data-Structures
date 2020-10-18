using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks.Enumerators
{
    class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] _stack;
        private int _top = 0;
        private int _position;
        public StackEnumerator(T[] stack,int top)
        {
            this._stack = stack;
            this._top = top;
            this._position = this._top;
        }
        public T Current 
        {
            get
            {
                return this._stack[this._position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            this._position--;
            return this._position > -1;
        }

        public void Reset()
        {
            this._position = this._top;
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
        // ~StackEnumerator()
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
