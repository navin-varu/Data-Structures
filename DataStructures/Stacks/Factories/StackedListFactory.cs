using DataStructures.Stacks.Abstracts;
using DataStructures.Stacks.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks.Factories
{
    class StackedListFactory<T> : IStackFactory<T>
    {
        public StackBase StackBase => StackBase.LinkedList;

        public AbstractStack<T> CreateStack(int size)
        {
            return new StackedList<T>(size);
        }
    }
}
