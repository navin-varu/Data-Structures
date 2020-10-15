using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories
{
    class QueuedListFactory<T> : IQueueFactory<T>
    {
        public QueueBase QueueBase => QueueBase.LinkedList;

        public AbstractQueue<T> CreateQueue(int size)
        {
            return new QueuedList<T>(size);
        }
    }
}
