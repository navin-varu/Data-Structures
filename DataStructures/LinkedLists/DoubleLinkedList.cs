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
        DoubleNode<T> tail = null;
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

        public override int GetLength()
        {
            int count = 0;
            if (head != null)
            {
                DoubleNode<T> current = head;
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
            Length = GetLength();
            T value;
            if (head == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else if (index < 1 || index > Length)
            {
                throw new IndexOutOfRangeException(ListCommon.INVALID_INDEX);
            }
            else
            {
                DoubleNode<T> current = head;
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
                else if (index == Length)
                {
                    InsertLast(value);
                }
                else
                {
                    DoubleNode<T> newNode = new DoubleNode<T>(value);
                    DoubleNode<T> current = head;
                    for (int i = 1; i < index - 1; i++)
                    {
                        current = current.next;
                    }
                    newNode.previous = current;
                    newNode.next = current.next;
                    current.next = newNode;
                    newNode.next.previous = newNode;
                }
            }
        }

        public override void InsertFirst(T value)
        {
            DoubleNode<T> newNode = new DoubleNode<T>(value);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                head.previous = newNode;
                newNode.next = head;
                head = newNode;
            }
        }

        public override void InsertLast(T value)
        {
            DoubleNode<T> newNode = new DoubleNode<T>(value);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.previous = tail;
                tail = newNode;
            }
        }

        public override bool IsEmpty()
        {
            return (head == null);
        }

        public override void RemoveAt(int index)
        {
            Length = GetLength();
            if (index < 1 || index > Length)
            {
                throw new IndexOutOfRangeException(ListCommon.INVALID_INDEX);
            }
            else if (head == null)
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
                    DoubleNode<T> current = head;
                    for (int i = 1; i < index; i++)
                    {
                        current = current.next;
                    }
                    current.previous.next = current.next;
                    current.next.previous = current.previous;
                }
            }
        }

        public override void RemoveFirst()
        {
            if (head == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else
            {
                head = head.next;
                head.previous = null;
            }
        }

        public override void RemoveLast()
        {
            if (tail == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else if (head.next == null)
            {
                head = head.next;
            }
            else
            {
                tail = tail.previous;
                tail.next = null;
            }
        }

        public override void Reverse()
        {
            if (head == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else if (head.next != null)
            {
                DoubleNode<T> current = head;
                DoubleNode<T> nextNode = null;
                while (current != null)
                {
                    nextNode = current.next;
                    current.next = current.previous;
                    current.previous = nextNode;
                    current = nextNode;

                }
                current = head;
                head = tail;
                tail = current;
            }
        }

        public override IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }
    }
}
