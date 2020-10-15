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
    public static class DequeFactory<T>
    {
        public static AbstractDeque<T> GetDeque(DequeBase dequeBase, int size)
        {
            AbstractDeque<T> dueue;
            switch (dequeBase)
            {
                case DequeBase.CircularArray:
                    dueue = new DequeCircularArray<T>(size);
                    break;
                default:
                    dueue = null;
                    break;
            }
            return dueue;
        }
    }
}
