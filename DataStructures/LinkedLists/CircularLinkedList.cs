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
    internal class CircularLinkedList : LinkedList
    {
        Node tail = null;
        private readonly string _linkedListName = "Circular";
        public override string LinkedListName => _linkedListName;

        public override void Clear()
        {
            tail = null;
        }

        public override void Create(string[] values)
        {
            tail = null;
            foreach (string value in values)
            {
                InsertLast(value);
            }
        }

        public override string Display()
        {
            string linkedList = "";
            if (tail == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else
            {
                Node current = tail.next;
                do
                {
                    linkedList += current._data;
                    linkedList += (current.next == tail.next) ? "." : "-->";
                    current = current.next;
                } while (current != tail.next);
            }
            return linkedList;
        }

        public override int GetLength()
        {
            int count = 0;
            if (tail != null)
            {
                Node current = tail.next;
                do
                {
                    count++;
                    current = current.next;
                } while (current != tail.next);
            }
            return count;
        }

        public override string GetValueAt(int index)
        {
            Length = GetLength();
            string value = "";
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
                Node current = tail.next;
                for (int i = 1; i < index; i++)
                {
                    current = current.next;
                }
                value = current._data;
            }
            return value;
        }

        public override void InsertAt(int index, string value)
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
                    Node newNode = new Node(value);
                    Node current = tail.next;
                    for (int i = 1; i < index - 1; i++)
                    {
                        current = current.next;
                    }
                    newNode.next = current.next;
                    current.next = newNode;
                }
            }
        }

        public override void InsertFirst(string value)
        {
            Node newNode = new Node(value);
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

        public override void InsertLast(string value)
        {
            Node newNode = new Node(value);
            if (tail == null)
            {
                newNode.next =  newNode;
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
                    Node current = tail.next;
                    Node previous = null;
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
                Node current = tail.next;
                Node previous = null;
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
                Node current = tail.next;
                Node previous = tail, nextNode = null;
                while (current != tail.next)
                {
                    nextNode = current.next;
                    current.next = previous;
                    previous = current;
                    current = nextNode;

                }
                tail = previous;
            }
        }

        public override IEnumerator GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }
    }
}
