using DataStructures.Queues.OperationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues.Abstracts
{
    public abstract class Deque : Queue, IDequeOperations
    {
        public abstract string DequeueRear();
        public abstract void EnqueueFront(string item);
        public abstract string PeakRear();
    }
}
