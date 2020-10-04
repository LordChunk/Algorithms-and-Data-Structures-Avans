using Alg1.Practica.Practicum1;
using Alg1.Practica.Utils;
namespace Alg1.Practica.Practicum3
{
    public class SelectionSortableNawArrayUnordered : NawArrayUnordered, ISelectionSort
    {
        public SelectionSortableNawArrayUnordered(int initialSize) : base(initialSize)
        {
        }

        public void SelectionSort()
        {
            for (var i = 0; i < _used - 1; i++)
            {
                var smallest = i;
                var itemMoved = false;

                for (var j = i + 1; j < _used; j++)
                {
                    if (_nawArray[j].CompareTo(_nawArray[smallest]) != -1) continue;
                    itemMoved = true;
                    smallest = j;
                }

                if (!itemMoved) continue;
                
                _nawArray.Swap(smallest, i);
            }
        }

        public void SelectionSortInverted()
        {
            for (var i = 0; i < _used - 1; i++)
            {
                var smallest = i;
                var itemMoved = false;

                for (var j = _used - 1; j > i; j--)
                {
                    if (_nawArray[j].CompareTo(_nawArray[smallest]) != -1) continue;
                    itemMoved = true;
                    smallest = j;
                }

                if (!itemMoved) continue;
                
                _nawArray.Swap(smallest, i);
            }
        }
    }
}
