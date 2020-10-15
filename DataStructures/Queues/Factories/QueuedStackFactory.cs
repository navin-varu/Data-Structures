using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories
{
    class QueuedStackFactory<T> : IQueueFactory<T>
    {
        public QueueBase QueueBase => QueueBase.Stack;

        public AbstractQueue<T> CreateQueue(int size)
        {
            return new QueuedStack<T>(size);
        }
    }
}
