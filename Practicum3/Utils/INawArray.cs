using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Utils
{
    public interface INawArray
    {
        void Add(NAW item);
        bool Remove(NAW item);
        int Find(NAW item);
        NAW ItemAtIndex(int index);
        void RemoveAtIndex(int index);

        void Show();

        int Count { get; set; }

        int ItemCount();

        Alg1NawArray Array { get; }
    }
}
