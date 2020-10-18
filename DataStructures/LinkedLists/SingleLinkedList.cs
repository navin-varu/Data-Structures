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
    internal class SingleLinkedList<T> : AbstractLinkedList<T>
    {
        Node<T> head = null;
        private readonly string _linkedListName = "Single";

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
                Node<T> current = head;
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
                else if (head == null)
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
                    Node<T> current = head;
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
            newNode.next = head;
            head = newNode;
        }

        public override void InsertLast(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
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
                    Node<T> current = head;
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
            if (head == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else
            {
                head = head.next;
            }
        }

        public override void RemoveLast()
        {
            if (head == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else if (head.next == null)
            {
                head = head.next;
            }
            else
            {
                Node<T> current = head;
                Node<T> previous = null;
                while (current.next != null)
                {
                    previous = current;
                    current = current.next;
                }
                previous.next = null;
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
                Node<T> current = head;
                Node<T> previous = null, nextNode = null;
                while (current != null)
                {
                    nextNode = current.next;
                    current.next = previous;
                    previous = current;
                    current = nextNode;

                }
                head = previous;
            }
        }

        public override IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator<T>(this);
        }
    }
}
