using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories
{
    class QueuedArrayFactory : IQueueFactory
    {
        public QueueBase QueueBase => QueueBase.Array;

        public Queue CreateQueue(int size)
        {
            return new QueuedArray(size);
        }
    }
}
