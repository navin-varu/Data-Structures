using DataStructures.OperationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists.OperationContracts
{
    /// <summary>
    /// 
    /// </summary>
    internal interface ILinkedListOperations<T>: IDataStructure<T>
    {
        void InsertFirst(T value);
        void InsertLast(T value);
        void InsertAt(int index, T value);
        void RemoveFirst();
        void RemoveLast();
        void RemoveAt(int index);
        void Reverse();
        void Create(T[] values);
        int GetLength();
        T GetValueAt(int index);
    }
}
