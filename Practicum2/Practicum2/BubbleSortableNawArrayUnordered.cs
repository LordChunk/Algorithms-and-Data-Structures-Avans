using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;

namespace Alg1.Practica.Practicum2
{
    public class BubbleSortableNawArrayUnordered : NawArrayUnordered, IBubbleSort
    {
        public BubbleSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void BubbleSort()
        {
            for (int outer = 0; outer < _used - 1; outer++)
            {
                for (int inner = 0; inner < _used - outer - 1; inner++)
                {
                    if (_nawArray[inner].CompareTo(_nawArray[inner + 1]) > 0)
                    {
                        _nawArray.Swap(inner, inner + 1);
                    }
                }
            }
        }

        public void BubbleSortInverted()
        {
            for (int outer = _used - 1; outer >= 0; outer--)
            {
                for (int inner = _used - 1; inner > _used - outer; inner--)
                {
                    if (_nawArray[inner].CompareTo(_nawArray[inner - 1]) < 0)
                    {
                        _nawArray.Swap(inner, inner - 1);
                    }
                }
            }
        }
    }
}
