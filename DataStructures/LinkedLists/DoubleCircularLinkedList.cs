using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Enumerators;

namespace DataStructures.LinkedLists
{
    internal class DoubleCircularLinkedList<T> : AbstractLinkedList<T>
    {
        public override string LinkedListName => throw new NotImplementedException();

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override void Create(T[] values)
        {
            throw new NotImplementedException();
        }        

        public override IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }

        public override int GetLength()
        {
            throw new NotImplementedException();
        }

        public override T GetValueAt(int index)
        {
            throw new NotImplementedException();
        }

        public override void InsertAt(int index, T value)
        {
            throw new NotImplementedException();
        }

        public override void InsertFirst(T value)
        {
            throw new NotImplementedException();
        }

        public override void InsertLast(T value)
        {
            throw new NotImplementedException();
        }

        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public override void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public override void RemoveFirst()
        {
            throw new NotImplementedException();
        }

        public override void RemoveLast()
        {
            throw new NotImplementedException();
        }

        public override void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
