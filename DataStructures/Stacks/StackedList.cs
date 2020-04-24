using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Enumerators;
using DataStructures.LinkedLists.Factories;
using DataStructures.Stacks.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack = DataStructures.Stacks.Abstracts.Stack;

namespace DataStructures.Stacks
{
    internal class StackedList : Stack
    {
        private readonly string _stackBaseType = "LinkedList";
        private readonly int _size = 0;
        private LinkedList _stack;
        public override int Size => this._size;

        public override string StackBaseType => this._stackBaseType;
        private StackedList()
        {

        }

        public StackedList(int size)
        {
            this.top = -1;
            this._size = size;
            this._stack = LinkedListFactory.GetLinkedList(LinkedListType.Single);
        }

        public override void Clear()
        {
            _stack.Clear();
        }

        public override string Display()
        {
            string stack = "";
            if (this._stack == null)
            {
                throw new Exception(StackCommon.NOT_INITIALIZED);
            }
            else if (IsEmpty())
            {
                throw new Exception(StackCommon.UNDER_FLOW);
            }
            else
            {
                stack = _stack.Display();
            }
            return stack;
        }

        public override bool IsEmpty()
        {
            return _stack.IsEmpty();
        }

        public override bool IsFull()
        {
            return (_stack.GetLength() == this._size);
        }

        public override string Peak()
        {
            string item = "";
            if (this._stack == null)
            {
                throw new Exception(StackCommon.NOT_INITIALIZED);
            }
            else if (IsEmpty())
            {
                throw new Exception(StackCommon.UNDER_FLOW);
            }
            else
            {
                item = this._stack.GetValueAt(1);
            }
            return item;
        }

        public override string Pop()
        {
            string item = "";
            if (this._stack == null)
            {
                throw new Exception(StackCommon.NOT_INITIALIZED);
            }
            else if (IsEmpty())
            {
                throw new Exception(StackCommon.UNDER_FLOW);
            }
            else
            {
                item = this._stack.GetValueAt(1);
                this._stack.RemoveFirst();
            }
            return item;
        }

        public override void Push(string item)
        {
            if (this._stack == null)
            {
                throw new Exception(StackCommon.NOT_INITIALIZED);
            }
            else if (IsFull())
            {
                throw new Exception(StackCommon.OVER_FLOW);
            }
            else
            {
                this._stack.InsertFirst(item);
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return new LinkedListEnumerator(this._stack);
        }
    }
}
