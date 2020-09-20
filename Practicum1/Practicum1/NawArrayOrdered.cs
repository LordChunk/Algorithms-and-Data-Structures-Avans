using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Exceptions;
using Alg1.Practica.Utils.Models;


namespace Alg1.Practica.Practicum1
{
    public class NawArrayOrdered : INawArray, INawArrayOrdered
    {
        protected Alg1NawArray _nawArray;

        public Alg1NawArray Array => _nawArray;

        protected int _size;
        protected int _used = 0;

        public NawArrayOrdered(int initialSize)
        {
            if (initialSize < 1 || initialSize > 1000000)
            {
                throw new NawArrayOrderedInvalidSizeException();
            }

            _size = initialSize;
            _nawArray = new Alg1NawArray(initialSize);
        }

        public void Show()
        {
            // Niet gevraagd

            System.Console.WriteLine("Array contains {0} of {1} items.", _used, _size);
            for (int i = 0; i < _size; i++)
            {
                if (i == _used)
                {
                    System.Console.WriteLine("------------------------------------------------------");
                }
                System.Console.Write("Item {0} contains: ", i);
                if (_nawArray[i] != null)
                {
                    _nawArray[i].Show();
                }
                else
                {
                    System.Console.WriteLine("nothing");
                }
            }
        }

        public int Count
        {
            get { return ItemCount(); }
            set { _used = value; }
        }

        public int ItemCount()
        {
            return _used;
        }

        public virtual void Add(NAW item)
        {
            if (_used >= _size)
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }

            int i = _used;
            while (i > 0 && item.CompareTo(_nawArray[i - 1]) == -1)
            {
                _nawArray[i] = _nawArray[i - 1];
                i--;
            }

            _nawArray[i] = item;

            _used++;
        }

        public void RemoveAtIndex(int index)
        {
            if (index < 0 || index > _size)
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }

            for (int i = index; i < _used; i++)
            {
                _nawArray[i] = _nawArray[i + 1];
                i++;
            }

            _nawArray[_used] = null;
            _used--;
        }

        public virtual bool Remove(NAW item)
        {
            int index = Find(item);

            if (index == -1) return false;

            RemoveAtIndex(index);
            return true;
        }

        public NAW ItemAtIndex(int index)
        {
            if (index < 0 || index > _size)
            {
                throw new NawArrayOrderedOutOfBoundsException();
            }

            return _nawArray[index];
        }


        public int Find(NAW item)
        {
            int begin = 0;
            int end = _used;

            bool searchedAllItems = false;
            while (!searchedAllItems)
            {
                int middle = (begin + end) / 2;

                switch (_nawArray[middle].CompareTo(item))
                {
                    case -1:
                        end = middle;
                        break;
                    case 0:
                        return middle;
                    case 1:
                        begin = middle;
                        break;
                }

                if (begin == end)
                {
                    searchedAllItems = true;
                }
            }

            return -1;
        }

        public bool Update(NAW oldValue, NAW newValue)
        {
            int oldIndex = Find(oldValue);

            if (oldIndex == -1) return false;

            RemoveAtIndex(oldIndex);

            Add(newValue);

            return true;
        }
    }
}


