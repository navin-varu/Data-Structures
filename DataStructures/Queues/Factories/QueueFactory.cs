using DataStructures.Queues.Abstracts;
using DataStructures.Queues.Factories.OperationContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues.Factories
{
    public sealed class QueueFactory<T>
    {
        private readonly Dictionary<QueueBase, IQueueFactory<T>> _factories;
        private static readonly Lazy<QueueFactory<T>> _queueFactory = new Lazy<QueueFactory<T>>(() => new QueueFactory<T>());
        public QueueFactory()
        {
            _factories = new Dictionary<QueueBase, IQueueFactory<T>>();
            InitializeFactories();
        }
        public static QueueFactory<T> GetFactory
        {
            get
            {
                return _queueFactory.Value;
            }
        }
        private void InitializeFactories()
        {
            Type[] factoryTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (Type factoryType in factoryTypes)
            {
                if (factoryType.GetInterface(typeof(IQueueFactory<T>).ToString()) != null)
                {
                    IQueueFactory<T> queueFactory = Activator.CreateInstance(factoryType) as IQueueFactory<T>;
                    if (queueFactory != null)
                    {
                        if (!_factories.ContainsKey(queueFactory.QueueBase))
                        {
                            _factories.Add(queueFactory.QueueBase, queueFactory);
                        }
                    }
                }
            }
        }

        public IQueueFactory<T> Load(QueueBase queueBase)
        {
            return this._factories[queueBase];
        }
    }
}
