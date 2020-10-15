using DataStructures.Stacks.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stacks.Factories.OperationContracts
{
    public interface IStackFactory<T>
    {
        StackBase StackBase { get; }
        AbstractStack<T> CreateStack(int size);
    }
}
