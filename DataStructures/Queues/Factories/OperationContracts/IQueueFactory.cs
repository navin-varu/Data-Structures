using DataStructures.Queues.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories.OperationContracts
{
    public interface IQueueFactory
    {
        QueueBase QueueBase { get; }
        Queue CreateQueue(int size);
    }
}
