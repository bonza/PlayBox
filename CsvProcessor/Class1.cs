using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProcessor
{
    public interface IConsumer
    {
        void Consume<T>(IEnumerable<T> producer);
    }

    public interface IProducer
    {
        IEnumerable<T> Produce<T>();
    }

    public class Service
    {
        private Dictionary<Type, IProducer> producers;

        public void Process<T>()
        {
        }

        void Register<T>(IProducer p, IConsumer c)
        {
            producers.Add(typeof(T), p);
        }
    }
}
