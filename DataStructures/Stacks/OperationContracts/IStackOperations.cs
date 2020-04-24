using DataStructures.OperationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stacks.OperationContracts
{
    internal interface IStackOperations : IDataStructure
    {
        void Push(string item);
        string Pop();
        bool IsFull();
        string Peak();
    }
}
