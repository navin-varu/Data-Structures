using DataStructures.Queues.OperationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues.Abstracts
{
    public abstract class AbstractDeque<T> : AbstractQueue<T>, IDequeOperations<T>
    {
        public abstract T DequeueRear();
        public abstract void EnqueueFront(T item);
        public abstract T PeakRear();
    }
}
