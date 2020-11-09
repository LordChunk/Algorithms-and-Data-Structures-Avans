using System.Collections.Generic;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueDotNet
    {
        private readonly Queue<NAW> _queue;

        public NawQueueDotNet()
        {
            _queue = new Queue<NAW>();
        }

        public void Enqueue(NAW naw)
        {
            _queue.Enqueue(naw);
        }

        public NAW Dequeue()
        {
            return Count() == 0 ? null : _queue.Dequeue();
        }

        public int Count()
        {
            return _queue.Count;
        }
    }
}
