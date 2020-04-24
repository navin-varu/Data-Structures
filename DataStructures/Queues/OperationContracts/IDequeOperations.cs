using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues.OperationContracts
{
    internal interface IDequeOperations : IQueueOperations
    {
        void EnqueueFront(string item);
        string DequeueRear();
        string PeakRear();
    }
}
