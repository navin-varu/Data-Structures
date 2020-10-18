using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.OperationContracts
{
    public interface IDataStructure<T> : IEnumerable<T>
    {
        void Clear();
        bool IsEmpty();
    }
}
