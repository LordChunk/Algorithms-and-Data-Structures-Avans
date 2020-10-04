using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum4
{
    public class NawDoublyLinkedList
    {
        public DoubleLink First { get; set; }
        public DoubleLink Last { get; set; }

        public void InsertHead(NAW naw)
        {
            // Create new item
            var newHead = new DoubleLink
            {
                Naw = naw,
                Next =  First
            };

            // Update current first item 
            if (First != null) First.Previous = newHead;

            // Check if last is unset (list is empty)
            if (Last == null) Last = newHead;

            // Add item to list
            First = newHead;
        }

        public NAW ItemAtIndex(int index)
        {
            int i = 0;
            var link = First;
            do
            {
                if (i == index)
                {
                    return link.Naw;
                }

                i++;
                link = link.Next;

            } while (link.Next != null);

            return null;
        }

        public DoubleLink SwapLinkWithNext(DoubleLink link)
        {
            throw new System.NotImplementedException();
        }

        public void BubbleSort()
        {
            throw new System.NotImplementedException();
        }

        public BigO OrderOfBubbleSort()
        {
            return BigO.N2;
        }
    }
}
