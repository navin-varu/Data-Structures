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
    public sealed class LinkedListFactory
    {
        private readonly Dictionary<LinkedListType, ILinkedListFactory> _factories;
        private static readonly Lazy<LinkedListFactory> _linkedListFactory = new Lazy<LinkedListFactory>(() => new LinkedListFactory());
        public LinkedListFactory()
        {
            _factories = new Dictionary<LinkedListType, ILinkedListFactory>();
            InitializeFactories();
        }
        public static LinkedListFactory GetFactory
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
                if (factoryType.GetInterface(typeof(ILinkedListFactory).ToString()) != null)
                {
                    ILinkedListFactory linkedListFactory = Activator.CreateInstance(factoryType) as ILinkedListFactory;
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

        public ILinkedListFactory Load(LinkedListType linkedListType)
        {
            return this._factories[linkedListType];
        }
        public static LinkedList GetLinkedList(LinkedListType linkedListType)
        {
            LinkedList linkedList;
            switch (linkedListType)
            {
                case LinkedListType.Single:
                    linkedList = new SingleLinkedList();
                    break;
                case LinkedListType.Circular:
                    linkedList = new CircularLinkedList();
                    break;
                case LinkedListType.Double:
                    linkedList = new DoubleLinkedList();
                    break;
                case LinkedListType.DoubleCircular:
                    linkedList = new DoubleCircularLinkedList();
                    break;
                default:
                    linkedList = null;
                    break;
            }
            return linkedList;
        }
    }
}
