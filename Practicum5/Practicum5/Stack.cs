using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum5
{
    public class Stack : IStack
    {
        protected StackLink First { get; set; }

        public void Push(string value)
        {
            var newFirst = new StackLink
            {
                Next = First,
                String = value,
            };

            First = newFirst;
        }

        public string Pop()
        {
            if (IsEmpty())
                return null;

            var returnableValue = First.String;
            First = First.Next;

            return returnableValue;
        }

        public string Peek()
        {
            return First?.String;
        }

        public bool IsEmpty()
        {
            return First == null;
        }
    }
}
