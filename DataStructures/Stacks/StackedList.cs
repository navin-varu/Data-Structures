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

namespace DataStructures.Stacks
{
    internal class StackedList<T> : AbstractStack<T>
    {
        private readonly string _stackBaseType = "LinkedList";
        private readonly int _size = 0;
        private AbstractLinkedList<T> _stack;
        public override int Size => this._size;

        public override string StackBaseType => this._stackBaseType;
        private StackedList()
        {

        }

        public StackedList(int size)
        {
            this.top = -1;
            this._size = size;
            this._stack = LinkedListFactory<T>.GetFactory.Load(LinkedListType.Single).CreateLinkedList();
        }

        public override void Clear()
        {
            _stack.Clear();
        }        

        public override bool IsEmpty()
        {
            return _stack.IsEmpty();
        }

        public override bool IsFull()
        {
            return (_stack.GetLength() == this._size);
        }

        public override T Peak()
        {
            T item;
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

        public override T Pop()
        {
            T item;
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

        public override void Push(T item)
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

        public override IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this._stack);
        }
    }
}
