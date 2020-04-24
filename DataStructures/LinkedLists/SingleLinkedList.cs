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
    internal class SingleLinkedList : LinkedList
    {
        Node head = null;
        private readonly string _linkedListName = "Single";

        public override string LinkedListName => _linkedListName;

        public override void Clear()
        {
            head = null;
        }

        public override void Create(string[] values)
        {
            head = null;
            foreach (string value in values)
            {
                InsertLast(value);
            }
        }

        public override string Display()
        {
            string linkedList = "";
            if (head == null)
            {
                throw new Exception(ListCommon.EMPTY_LIST);
            }
            else
            {
                Node current = head;
                do
                {
                    linkedList += current._data;
                    linkedList += (current.next == null) ? "." : "-->";
                    current = current.next;
                } while (current != null);
            }
            return linkedList;
        }

        public override int GetLength()
        {
            int count = 0;
            if (head != null)
            {
                Node current = head;
                do
                {
                    count++;
                    current = current.next;
                } while (current != null);
            }
            return count;
        }

        public override string GetValueAt(int index)
        {
            Length = GetLength();
            string value = "";
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
                Node current = head;
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
                    Node newNode = new Node(value);
                    Node current = head;
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
            newNode.next = head;
            head = newNode;
        }

        public override void InsertLast(string value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node current = head;
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
                    Node current = head;
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
                Node current = head;
                Node previous = null;
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
                Node current = head;
                Node previous = null, nextNode = null;
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

        public override IEnumerator GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }
    }
}
