using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DataStructures.LinkedLists.Abstracts;
using DataStructures.LinkedLists.Factories.OperationContracts;

namespace DataStructures.LinkedLists.Factories
{
    public sealed class LinkedListFactory<T>
    {
        private readonly Dictionary<LinkedListType, ILinkedListFactory<T>> _factories;
        private static readonly Lazy<LinkedListFactory<T>> _linkedListFactory = new Lazy<LinkedListFactory<T>>(() => new LinkedListFactory<T>());
        public LinkedListFactory()
        {
            _factories = new Dictionary<LinkedListType, ILinkedListFactory<T>>();
            InitializeFactories();
        }
        public static LinkedListFactory<T> GetFactory
        {
            get
            {
                return _linkedListFactory.Value;
            }
        }
        private void InitializeFactories()
        {
            Type[] factoryTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach(Type factoryType in factoryTypes)
            {
                if (factoryType.GetInterface(typeof(ILinkedListFactory<T>).ToString()) != null)
                {
                    ILinkedListFactory<T> linkedListFactory = Activator.CreateInstance(factoryType) as ILinkedListFactory<T>;
                    if (linkedListFactory != null)
                    {
                        if (!_factories.ContainsKey(linkedListFactory.LinkedListType))
                        {
                            _factories.Add(linkedListFactory.LinkedListType, linkedListFactory);
                        }
                    }
                }
            }
        }

        public ILinkedListFactory<T> Load(LinkedListType linkedListType)
        {
            return this._factories[linkedListType];
        }
        public static AbstarctLinkedList<T> GetLinkedList(LinkedListType linkedListType)
        {
            AbstarctLinkedList<T> linkedList;
            switch (linkedListType)
            {
                case LinkedListType.Single:
                    linkedList = new SingleLinkedList<T>();
                    break;
                case LinkedListType.Circular:
                    linkedList = new CircularLinkedList<T>();
                    break;
                case LinkedListType.Double:
                    linkedList = new DoubleLinkedList<T>();
                    break;
                case LinkedListType.DoubleCircular:
                    linkedList = new DoubleCircularLinkedList<T>();
                    break;
                default:
                    linkedList = null;
                    break;
            }
            return linkedList;
        }
    }
}
