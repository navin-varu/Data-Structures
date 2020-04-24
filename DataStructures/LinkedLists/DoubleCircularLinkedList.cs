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
    internal class DoubleCircularLinkedList : LinkedList
    {
        public override string LinkedListName => throw new NotImplementedException();

        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override void Create(string[] values)
        {
            throw new NotImplementedException();
        }

        public override string Display()
        {
            throw new NotImplementedException();
        }

        public override IEnumerator GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }

        public override int GetLength()
        {
            throw new NotImplementedException();
        }

        public override string GetValueAt(int index)
        {
            throw new NotImplementedException();
        }

        public override void InsertAt(int index, string value)
        {
            throw new NotImplementedException();
        }

        public override void InsertFirst(string value)
        {
            throw new NotImplementedException();
        }

        public override void InsertLast(string value)
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
