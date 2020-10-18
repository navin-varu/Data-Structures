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
    internal class CircularLinkedList<T> : AbstractLinkedList<T>
    {
        Node<T> tail = null;
        private readonly string _linkedListName = "Circular";
        public override string LinkedListName => _linkedListName;

        public override void Clear()
        {
            tail = null;
        }

        public override void Create(T[] values)
        {
            tail = null;
            foreach (T value in values)
            {
                InsertLast(value);
            }
        }


        public override int GetLength()
        {
            int count = 0;
            if (tail != null)
            {
                Node<T> current = tail.next;
                do
                {
                    count++;
                    current = current.next;
                } while (current != tail.next);
            }
            return count;
        }

        public override T GetValueAt(int index)
        {
            Length = GetLength();
            T value;
            if (tail == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else if (index < 1 || index > Length)
            {
                throw new IndexOutOfRangeException(ListCommon.INVALID_INDEX);
            }
            else
            {
                Node<T> current = tail.next;
                for (int i = 1; i < index; i++)
                {
                    current = current.next;
                }
                value = current._data;
            }
            return value;
        }

        public override void InsertAt(int index, T value)
        {
            Length = GetLength();
            if (index < 1 || index > Length)
            {
                throw new IndexOutOfRangeException(ListCommon.INVALID_INDEX);
            }
            else
            {
                if (index == 1)
                {
                    InsertFirst(value);
                }
                else if (tail == null)
                {
                    throw new Exception(ListCommon.EMPTY_INDEX_INSERT);
                }
                else if (index == Length)
                {
                    InsertLast(value);
                }
                else
                {
                    Node<T> newNode = new Node<T>(value);
                    Node<T> current = tail.next;
                    for (int i = 1; i < index - 1; i++)
                    {
                        current = current.next;
                    }
                    newNode.next = current.next;
                    current.next = newNode;
                }
            }
        }

        public override void InsertFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (tail == null)
            {
                newNode.next = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = tail.next;
                tail.next = newNode;
            }
        }

        public override void InsertLast(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (tail == null)
            {
                newNode.next = newNode;
            }
            else
            {
                newNode.next = tail.next;
                tail.next = newNode;
            }
            tail = newNode;
        }

        public override bool IsEmpty()
        {
            return (tail == null);
        }

        public override void RemoveAt(int index)
        {
            Length = GetLength();
            if (index < 1 || index > Length)
            {
                throw new IndexOutOfRangeException(ListCommon.INVALID_INDEX);
            }
            else if (tail == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else
            {
                if (index == 1)
                {
                    RemoveFirst();
                }
                else if (index == Length)
                {
                    RemoveLast();
                }
                else
                {
                    Node<T> current = tail.next;
                    Node<T> previous = null;
                    for (int i = 1; i < index; i++)
                    {
                        previous = current;
                        current = current.next;
                    }
                    previous.next = current.next;
                }
            }
        }

        public override void RemoveFirst()
        {
            if (tail == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else
            {
                tail.next = tail.next.next;
            }
        }

        public override void RemoveLast()
        {
            if (tail == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else
            {
                Node<T> current = tail.next;
                Node<T> previous = null;
                while (current.next != tail.next)
                {
                    previous = current;
                    current = current.next;
                }
                previous.next = tail.next;
                tail = previous;
            }
        }

        public override void Reverse()
        {
            if (tail == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else if (tail.next != tail)
            {
                Node<T> current = tail.next;
                Node<T> nextNode = current.next, previous = null;
                while (current != tail)
                {
                    previous = current;
                    current = nextNode;
                    nextNode = current.next;
                    current.next = previous;

                }
                nextNode.next = tail;
                tail = nextNode;
            }
        }

        public override IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }
    }
}
