using DataStructures.Stacks.Abstracts;
using DataStructures.Stacks.Enumerators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack = DataStructures.Stacks.Abstracts.Stack;

namespace DataStructures.Stacks
{
    internal class StackedArray : Stack
    {
        private readonly string _stackBaseType = "Array";
        private readonly int _size = 0;
        private string[] _stack;

        public override int Size => _size;

        public override string StackBaseType => _stackBaseType;
        private StackedArray()
        {

        }
        public StackedArray(int size)
        {
            this.top = -1;
            this._size = size;
            this._stack = new string[this._size];
        }
        public override void Clear()
        {
            top = -1;
            this._stack = null;
            this._stack = new string[this._size];
        }

        public override string Display()
        {
            string stack = "";
            if (this._size == 0)
            {
                throw new Exception(StackCommon.NOT_INITIALIZED);
            }
            else if (top == -1)
            {
                throw new Exception(StackCommon.UNDER_FLOW);
            }
            else
            {
                for (int i = this.top; i >= 0; i--)
                {
                    stack += this._stack[i];
                    stack += (i == 0) ? "." : "-->";
                }
            }
            return stack;
        }

        public override bool IsEmpty()
        {
            return (this.top == -1);
        }

        public override bool IsFull()
        {
            return (this.top == this._size - 1);
        }

        public override string Peak()
        {
            string item = "";
            if (this._size == 0)
            {
                throw new Exception(StackCommon.NOT_INITIALIZED);
            }
            else if (top == -1)
            {
                throw new Exception(StackCommon.UNDER_FLOW);
            }
            else
            {
                item = this._stack[this.top];
            }
            return item;
        }

        public override string Pop()
        {
            string item = "";
            if (this._size == 0)
            {
                throw new Exception(StackCommon.NOT_INITIALIZED);
            }
            else if (top == -1)
            {
                throw new Exception(StackCommon.UNDER_FLOW);
            }
            else
            {
                item = this._stack[this.top--];
            }
            return item;
        }

        public override void Push(string item)
        {
            if (this._size == 0)
            {
                throw new Exception(StackCommon.NOT_INITIALIZED);
            }
            else if (top == this._size - 1)
            {
                throw new Exception(StackCommon.OVER_FLOW);
            }
            else
            {
                this._stack[++this.top] = item;
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return new StackEnumerator(this._stack, this.top);
        }
    }
}
