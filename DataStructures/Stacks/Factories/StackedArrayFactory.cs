using DataStructures.Stacks.Abstracts;
using DataStructures.Stacks.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks.Factories
{
    class StackedArrayFactory : IStackFactory
    {
        public StackBase StackBase => StackBase.Array;

        public Stack CreateStack(int size)
        {
            return new StackedArray(size);
        }
    }
}
