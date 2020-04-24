using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees.Nodes
{
    internal class TreeNode
    {
        internal string _data;
        internal TreeNode left;
        internal TreeNode right;

        public TreeNode(string data)
        {
            _data = data;
            left = right = null;
        }
    }
}
