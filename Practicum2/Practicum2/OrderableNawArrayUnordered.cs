using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;

namespace Alg1.Practica.Practicum2
{
    public class OrderableNawArrayUnordered : NawArrayUnordered, IToNawArrayOrdered
    {
        public OrderableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public INawArrayOrdered ToNawArrayOrdered()
        {
            NawArrayOrdered orderedArray = new NawArrayOrdered(_size);

            for (int i = 0; i < _nawArray.Size; i++)
            {
              orderedArray.Add(_nawArray[i]);  
            }

            return orderedArray;
        }
    }
}
