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
    internal interface ILinkedListOperations: IDataStructure
    {
        void InsertFirst(string value);
        void InsertLast(string value);
        void InsertAt(int index,string value);
        void RemoveFirst();
        void RemoveLast();
        void RemoveAt(int index);
        void Reverse();
        void Create(string[] values);
        int GetLength();
        string GetValueAt(int index);
    }
}
