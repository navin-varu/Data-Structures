using DataStructures.Queues.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories.OperationContracts
{
    public interface IQueueFactory<T>
    {
        QueueBase QueueBase { get; }
        AbstractQueue<T> CreateQueue(int size);
    }
}
