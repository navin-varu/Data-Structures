using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories
{
    class QueuedCircularArrayFactory : IQueueFactory
    {
        public QueueBase QueueBase => QueueBase.CircularArray;

        public Queue CreateQueue(int size)
        {
            return new QueuedCircularArray(size);
        }
    }
}
