using DataStructures.OperationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues.OperationContracts
{
    internal interface IQueueOperations: IDataStructure
    {
        void Enqueue(string item);
        string Dequeue();
        bool IsFull();
        string Peak();
    }
}
