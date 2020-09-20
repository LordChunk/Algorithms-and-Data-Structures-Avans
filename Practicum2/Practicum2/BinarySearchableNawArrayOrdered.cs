using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;
using Alg1.Practica.Practicum1;


namespace Alg1.Practica.Practicum2
{
    public class BinarySearchableNawArrayOrdered : NawArrayOrdered, IBinarySearch
    {
        public BinarySearchableNawArrayOrdered(int initialSize) : base(initialSize)
        { }

        public int FindBinary(NAW item)
        {
            int min = 0;
            int max = _used - 1;
            while (min <= max)
            {
                int center = (min + max) / 2;
                int compareToResult = _nawArray[center].CompareTo(item);

                // Item can be placed in this position 
                if (compareToResult == 0)
                {
                    return center;
                }

                if (compareToResult < 0)
                {
                    min = center + 1;
                }
                else
                {
                    max = center - 1;
                }
            }

            return -1;
        }

        public void AddBinary(NAW item)
        {
            if (_used >= _size)
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }

            int min = 0;
            int max = _used - 1;
            int indexForNewItem = 0;
            while (min <= max)
            {
                int center = (min + max) / 2;
                int compareToResult = _nawArray[center].CompareTo(item);

                // Item can be placed in this position 
                if (compareToResult == 0)
                {
                    indexForNewItem = center;
                    break;
                }

                if (compareToResult < 0)
                {
                    min = center + 1;
                }
                else
                {
                    max = center - 1;
                }
            }

            // if no position is found append item to end of array
            if (indexForNewItem == 0)
            {
                indexForNewItem = min;
            }

            // move other items
            for (int i = _used; i > indexForNewItem; i--)
            {
                _nawArray[i] = _nawArray[i - 1];
            }

            _nawArray[indexForNewItem] = item;

            _used++;
        }
    }
}
