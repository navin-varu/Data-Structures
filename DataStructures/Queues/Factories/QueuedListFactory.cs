using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories
{
    class QueuedListFactory : IQueueFactory
    {
        public QueueBase QueueBase => QueueBase.LinkedList;

        public Queue CreateQueue(int size)
        {
            return new QueuedList(size);
        }
    }
}
