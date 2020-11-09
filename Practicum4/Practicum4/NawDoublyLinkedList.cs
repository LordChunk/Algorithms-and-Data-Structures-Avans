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
            var i = 0;
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

        public DoubleLink SwapLinkWithNext(DoubleLink linkI)
        {
            var linkJ = linkI.Next;

            if (linkJ == null) return null;

            var linkH = linkI.Previous;
            var linkK = linkJ.Next;

            if (First == linkI)
            {
                First = linkJ;
            }

            if (linkH != null)
            {
                linkH.Next = linkJ;
            }

            linkJ.Previous = linkH;
            linkJ.Next = linkI;
            linkI.Previous = linkJ;
            linkI.Next = linkK;

            if (linkK != null)
            {
                linkK.Previous = linkI;
            }

            if (Last == linkJ)
            {
                Last = linkI;
            }

            return linkJ;
        }

        public void BubbleSort()
        {
            var tmpLast = Last;

            do
            {
                var itemMoved = false;

                var tmpFirst = First;

                while (tmpFirst.Next != null && tmpFirst != tmpLast)
                {
                    if (tmpFirst.Naw.CompareTo(tmpFirst.Next.Naw) == 1)
                    {
                        SwapLinkWithNext(tmpFirst);
                        tmpFirst = tmpFirst.Previous;
                        itemMoved = true;
                    }

                    tmpFirst = tmpFirst.Next;
                }

                if (!itemMoved) break;
            } while (tmpLast.Previous != null);
        }

        public BigO OrderOfBubbleSort()
        {
            return BigO.N2;
        }
    }
}
