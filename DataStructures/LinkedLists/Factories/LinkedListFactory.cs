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

        private LinkedListFactory()
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
            var factoryTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach(Type factoryType in factoryTypes)
            {
                if (factoryType.GetInterface(typeof(ILinkedListFactory).ToString()) != null)
                {
                    if (!factoryType.IsInterface)
                    {
                        Type[] typeArgs = { typeof(T) };
                        Type genericFactoryType = factoryType.MakeGenericType(typeArgs);
                        ILinkedListFactory<T> linkedListFactory = Activator.CreateInstance(genericFactoryType) as ILinkedListFactory<T>;
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
        }

        public ILinkedListFactory<T> Load(LinkedListType linkedListType)
        {
            return this._factories[linkedListType];
        }       
    }
}
