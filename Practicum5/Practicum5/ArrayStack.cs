using Alg1.Practica.Utils;
using System;

namespace Alg1.Practica.Practicum5
{
    public class ArrayStack : IStack
    {
        protected string[] values;
        protected int size;
        protected int used;

        public ArrayStack(int capacity)
        {
            values = new string[capacity];
            size = capacity;
        }

        public void Push(string value)
        {
            if (IsFull())
                throw new InvalidProgramException();
            values[used++] = value;
        }

        public string Pop() => IsEmpty() ? null : values[used-- - 1];

        public string Peek() => IsEmpty() ? null : values[used - 1];

        public bool IsEmpty() => used == 0;

        public bool IsFull() => used == size;
    }
}