using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories
{
    class QueuedArrayFactory<T> : IQueueFactory<T>
    {
        public QueueBase QueueBase => QueueBase.Array;

        public AbstractQueue<T> CreateQueue(int size)
        {
            return new QueuedArray<T>(size);
        }
    }
}
