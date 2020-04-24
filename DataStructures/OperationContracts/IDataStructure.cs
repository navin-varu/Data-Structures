using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.OperationContracts
{
    public interface IDataStructure : IEnumerable
    {
        void Clear();
        bool IsEmpty();
        string Display();
    }
}
