using DataStructures.Stacks.Abstracts;
using DataStructures.Stacks.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stacks.Factories
{
    public sealed class StackFactory<T>
    {
        private readonly Dictionary<StackBase, IStackFactory<T>> _factories;
        private static readonly Lazy<StackFactory<T>> _stackFactory = new Lazy<StackFactory<T>>(() => new StackFactory<T>());

        public StackFactory()
        {
            _factories = new Dictionary<StackBase, IStackFactory<T>>();
            InitializeFactories();
        }
        public static StackFactory<T> GetFactory
        {
            get
            {
                return _stackFactory.Value;
            }
        }
        private void InitializeFactories()
        {
            Type[] factoryTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type factoryType in factoryTypes)
            {
                if (factoryType.GetInterface(typeof(IStackFactory<T>).ToString()) != null)
                {
                    IStackFactory<T> stackFactory = Activator.CreateInstance(factoryType) as IStackFactory<T>;
                    if (stackFactory != null)
                    {
                        if (!_factories.ContainsKey(stackFactory.StackBase))
                        {
                            _factories.Add(stackFactory.StackBase, stackFactory);
                        }
                    }
                }
            }
        }

        public IStackFactory<T> Load(StackBase stackBase)
        {
            return this._factories[stackBase];
        }
        public static AbstractStack<T> GetStack(StackBase stackBase, int size)
        {
            AbstractStack<T> stack;
            switch (stackBase)
            {
                case StackBase.Array:
                    stack = new StackedArray<T>(size);
                    break;
                case StackBase.LinkedList:
                    stack = new StackedList<T>(size);
                    break;
                default:
                    stack = null;
                    break;
            }
            return stack;
        }
    }
}
