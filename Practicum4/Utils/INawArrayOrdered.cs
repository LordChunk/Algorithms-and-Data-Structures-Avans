using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Utils
{
    public interface INawArrayOrdered : INawArray
    {
        //int Find(NAW item);

        //void RemoveAtIndex(int index);

        bool Update(NAW oldValue, NAW newValue);
        /* Niet langer gevraagd 
        bool Remove(NAW item);
        void UpdateAll(NAW item, NAW newValue);
        */
    }

}
