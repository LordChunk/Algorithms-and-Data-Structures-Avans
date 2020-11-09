using System;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueLinkedList
    {
        public Link First { get; set; }

        protected Link Last { get; set; }

        protected int _count;

        public void Enqueue(NAW naw)
        {
            var newLink = new Link
            {
                Naw = naw
            };

            if (_count++ == 0)
                First = Last = newLink;
            else
                Last.Next = Last = newLink;
        }

        public NAW Dequeue()
        {
            if (_count <= 0)
                return null; //Of exception

            var tmpLink = First.Naw;
            First = First.Next;

            if (First == null)
                Last = null;

            _count--;
            return tmpLink;
        }

        public int Count()
        {
            return _count;
        }
    }

}
