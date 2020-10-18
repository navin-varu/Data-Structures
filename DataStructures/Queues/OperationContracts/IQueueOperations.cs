using DataStructures.OperationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues.OperationContracts
{
    internal interface IQueueOperations<T>: IDataStructure<T>
    {
        void Enqueue(T item);
        T Dequeue();
        bool IsFull();
        T Peak();
    }
}
