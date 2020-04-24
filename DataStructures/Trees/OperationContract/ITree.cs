using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees.OperationContract
{
    interface ITree
    {
        void Insert(string data);
        void Delete();
        string Display();
    }
}
