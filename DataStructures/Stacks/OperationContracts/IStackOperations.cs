using DataStructures.OperationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stacks.OperationContracts
{
    internal interface IStackOperations<T> : IDataStructure
    {
        void Push(T item);
        T Pop();
        bool IsFull();
        T Peak();
    }
}
