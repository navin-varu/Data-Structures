using DataStructures.Stacks.Abstracts;
using DataStructures.Stacks.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks.Factories
{
    class StackedArrayFactory<T> : IStackFactory<T>
    {
        public StackBase StackBase => StackBase.Array;

        public AbstractStack<T> CreateStack(int size)
        {
            return new StackedArray<T>(size);
        }
    }
}
