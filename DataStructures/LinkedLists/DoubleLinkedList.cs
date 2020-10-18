using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Enumerators;
using DataStructures.LinkedLists.Nodes;

namespace DataStructures.LinkedLists
{
    internal class DoubleLinkedList<T> : AbstractLinkedList<T>
    {
        DoubleNode<T> head = null;
        private readonly string _linkedListName = "Double";
        public override string LinkedListName => _linkedListName;

        public override void Clear()
        {
            head = null;
        }

        public override void Create(T[] values)
        {
            head = null;
            foreach (T value in values)
            {
                InsertLast(value);
            }
        }

       
        public override IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }

        public override int GetLength()
        {
            int count = 0;
            if (head != null)
            {
                Node<T> current = head;
                do
                {
                    count++;
                    current = current.next;
                } while (current != null);
            }
            return count;
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
