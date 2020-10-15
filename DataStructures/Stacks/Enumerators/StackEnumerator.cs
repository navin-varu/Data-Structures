using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks.Enumerators
{
    class StackEnumerator<T> : IEnumerator
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
        public object Current 
        {
            get
            {
                return this._stack[this._position];
            }
        }

        public bool MoveNext()
        {
            this._position--;
            return this._position > -1;
        }

        public void Reset()
        {
            this._position = this._top;
        }
    }
}
