﻿using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists.Factories
{
    class SingleLinkedListFactory<T> : ILinkedListFactory<T>
    {
        public LinkedListType LinkedListType => LinkedListType.Single;

        public AbstractLinkedList<T> CreateLinkedList()
        {
            return new SingleLinkedList<T>();
        }
    }
}
