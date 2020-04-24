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
    public sealed class StackFactory
    {
        private readonly Dictionary<StackBase, IStackFactory> _factories;
        private static readonly Lazy<StackFactory> _stackFactory = new Lazy<StackFactory>(() => new StackFactory());
        public StackFactory()
        {
            _factories = new Dictionary<StackBase, IStackFactory>();
            InitializeFactories();
        }
        public static StackFactory GetFactory
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
                if (factoryType.GetInterface(typeof(IStackFactory).ToString()) != null)
                {
                    IStackFactory stackFactory = Activator.CreateInstance(factoryType) as IStackFactory;
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

        public IStackFactory Load(StackBase stackBase)
        {
            return this._factories[stackBase];
        }
        public static Stack GetStack(StackBase stackBase, int size)
        {
            Stack stack;
            switch (stackBase)
            {
                case StackBase.Array:
                    stack = new StackedArray(size);
                    break;
                case StackBase.LinkedList:
                    stack = new StackedList(size);
                    break;
                default:
                    stack = null;
                    break;
            }
            return stack;
        }
    }
}
