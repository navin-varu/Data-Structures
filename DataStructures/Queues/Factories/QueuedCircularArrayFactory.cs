using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories
{
    class QueuedCircularArrayFactory<T> : IQueueFactory<T>
    {
        public QueueBase QueueBase => QueueBase.CircularArray;

        public AbstractQueue<T> CreateQueue(int size)
        {
            return new QueuedCircularArray<T>(size);
        }
    }
}
