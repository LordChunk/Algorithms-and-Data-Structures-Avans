using System;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum6
{
    public class NawQueueArray
    {
        public int Front { get; set; }

        public int Rear { get; set; }

        protected Alg1NawArray _array; // interne array
        protected int _count; // aantal gebruikte index in interne array
        protected int _size; // maximale omvang van interne array

        public NawQueueArray(int initialSize)
        {
            // aanmaken intern array
            if ((initialSize > 0) && (initialSize <= 1000))
            {
                _size = initialSize;
            }
            else
            {
                throw new NawQueueArrayInvalidSizeException();
            }

            _array = new Alg1NawArray(_size);

            // verdere initialisatie

            Front = 0;
            Rear = -1;
        }

        public void Enqueue(NAW naw)
        {
            if(_count == _size)
                throw new NawQueueArrayOutOfBoundsException();

            if (Rear == _size - 1)
                Rear = 0;
            else
                Rear++;

            _array[Rear] = naw;
            _count++;
        }

        public NAW Dequeue()
        {
            var returnValue = _array[Front];

            if (returnValue == null) return null;

            if (Front == _size - 1)
                Front = 0;
            else
                Front++;

            _count--;
            return returnValue;
        }

        public int Count()
        {
            return _count;
        }
    }

}
