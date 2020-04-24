using DataStructures.Queues.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues.Factories
{
    public enum DequeBase
    {
        CircularArray
    }
    public static class DequeFactory
    {
        public static Deque GetDeque(DequeBase dequeBase, int size)
        {
            Deque dueue;
            switch (dequeBase)
            {
                case DequeBase.CircularArray:
                    dueue = new DequeCircularArray(size);
                    break;
                default:
                    dueue = null;
                    break;
            }
            return dueue;
        }
    }
}
