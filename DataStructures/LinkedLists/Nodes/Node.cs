using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists.Nodes
{
    internal class Node
    {
        internal string _data;
        internal Node next;
        public Node(string data)
        {
            _data = data;
            next = null;
        }
    }

    internal class DoubleNode : Node
    {
        internal Node previous;
        public DoubleNode(string data) : base(data)
        {
            previous = null;
        }
    }
}
