using DataStructures.Stacks.Abstracts;
using DataStructures.Stacks.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks.Factories
{
    class StackedListFactory : IStackFactory
    {
        public StackBase StackBase => StackBase.LinkedList;

        public Stack CreateStack(int size)
        {
            return new StackedList(size);
        }
    }
}
