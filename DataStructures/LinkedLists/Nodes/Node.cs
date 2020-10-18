using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists.Nodes
{
    internal class Node<T>
    {
        internal T _data;
        internal Node<T> next;
        public Node(T data)
        {
            _data = data;
            next = null;
        }
    }

    internal class DoubleNode<T>
    {
        internal T _data;
        internal DoubleNode<T> next;
        internal DoubleNode<T> previous;
        public DoubleNode(T data)
        {
            _data = data;
            next = null;
            previous = null;
        }
    }
}
