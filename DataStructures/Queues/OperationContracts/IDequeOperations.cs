using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues.OperationContracts
{
    internal interface IDequeOperations<T> : IQueueOperations<T>
    {
        void EnqueueFront(T item);
        T DequeueRear();
        T PeakRear();
    }
}
