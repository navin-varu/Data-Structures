using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queues.Factories
{
    class QueuedStackFactory : IQueueFactory
    {
        public QueueBase QueueBase => QueueBase.Stack;

        public Queue CreateQueue(int size)
        {
            return new QueuedStack(size);
        }
    }
}
