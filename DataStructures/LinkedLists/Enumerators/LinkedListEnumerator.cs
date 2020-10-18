using DataStructures.LinkedLists.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Enumerators
{
    public class LinkedListEnumerator<T> : IEnumerator<T>
    {
        private readonly AbstractLinkedList<T> _linkedList;
        private int _length;
        private int _position;
        public LinkedListEnumerator(AbstractLinkedList<T> linkedList)
        {
            this._linkedList = linkedList;
            this._length = this._linkedList.GetLength();
            this._position = 0;
        }        

        public T Current
        {
            get
            {
                return this._linkedList.GetValueAt(_position);
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            this._position++;
            return this._position <= this._length;
        }

        public void Reset()
        {
            this._position = -1;
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
        // ~LinkedListEnumerator()
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
