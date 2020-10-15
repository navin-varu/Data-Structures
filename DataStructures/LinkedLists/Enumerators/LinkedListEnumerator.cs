using DataStructures.LinkedLists.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Enumerators
{
    class LinkedListEnumerator<T> : IEnumerator
    {
        private readonly AbstarctLinkedList<T> _linkedList;
        private int _length;
        private int _position;
        public LinkedListEnumerator(AbstarctLinkedList<T> linkedList)
        {
            this._linkedList = linkedList;
            this._length = this._linkedList.GetLength();
            this._position = -1;
        }
        public object Current
        {
            get
            {
                return this._linkedList.GetValueAt(_position);
            }
        }
        public bool MoveNext()
        {
            this._position++;
            return this._position < this._length;
        }

        public void Reset()
        {
            this._position = -1;
        }
    }
}
