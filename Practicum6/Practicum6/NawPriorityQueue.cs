using System;
using System.Collections.Generic;
using System.Linq;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawPriorityQueue
    {

        private SortedDictionary<int, NawQueueLinkedList> _priorityQueue;

        public NawPriorityQueue()
        {
            _priorityQueue = new SortedDictionary<int, NawQueueLinkedList>();
        }

        public void Enqueue(int priority, NAW naw)
        {
            if(!_priorityQueue.ContainsKey(priority))
                _priorityQueue.Add(priority, new NawQueueLinkedList());

            _priorityQueue[priority].Enqueue(naw);
        }

        public NAW Dequeue()
        {
            foreach (var key in _priorityQueue.Keys)
            {
                var returnValue = _priorityQueue[key].Dequeue();

                if (returnValue != null)
                {
                    return returnValue;
                }
            }

            return null;
        }

        public int Count()
        {
            return _priorityQueue.Keys.Sum(key => _priorityQueue[key].Count());
        }

        public void Show()
        {
            // Deze methode is handig bij het debuggen maar wordt niet nagekeken
        }
    }
}
