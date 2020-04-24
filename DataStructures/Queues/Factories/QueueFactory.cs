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
    public sealed class QueueFactory
    {
        private readonly Dictionary<QueueBase, IQueueFactory> _factories;
        private static readonly Lazy<QueueFactory> _queueFactory = new Lazy<QueueFactory>(() => new QueueFactory());
        public QueueFactory()
        {
            _factories = new Dictionary<QueueBase, IQueueFactory>();
            InitializeFactories();
        }
        public static QueueFactory GetFactory
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
                if (factoryType.GetInterface(typeof(IQueueFactory).ToString()) != null)
                {
                    IQueueFactory queueFactory = Activator.CreateInstance(factoryType) as IQueueFactory;
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

        public IQueueFactory Load(QueueBase queueBase)
        {
            return this._factories[queueBase];
        }
        public static Queue GetQueue(QueueBase queueBase, int size)
        {
            Queue queue;
            switch (queueBase)
            {
                case QueueBase.Array:
                    queue = new QueuedArray(size);
                    break;
                case QueueBase.CircularArray:
                    queue = new QueuedCircularArray(size);
                    break;
                case QueueBase.LinkedList:
                    queue = new QueuedList(size);
                    break;
                default:
                    queue = null;
                    break;
            }
            return queue;
        }
    }
}
