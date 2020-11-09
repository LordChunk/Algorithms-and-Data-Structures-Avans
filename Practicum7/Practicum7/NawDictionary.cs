using System;
using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;

namespace Alg1.Practica.Practicum7
{
    public class NawDictionary : INawDictionary
    {
        public int Size { get; }
        private int count;
        protected LogFile[] logFiles;

        public NawDictionary(int size)
        {
            Size = size;
            count = 0;
            logFiles = new LogFile[size];
            for (var i = 0; i < logFiles.Length; ++i)
                logFiles[i] = new LogFile();
        }

        protected int KeyToIndex(string key)
        {
            if (key == null) throw new ArgumentNullException();

            return Math.Abs(key.GetHashCode() & Size);
        }



        public void Insert(string key, NAW value)
        {
            if(key == null) throw new ArgumentNullException();

            var index = KeyToIndex(key);
            logFiles[index].Insert(key, value);
            count++;
        }

        public NAW Find(string key)
        {
            if(key == null) throw new ArgumentNullException();
            var index = KeyToIndex(key);
            return logFiles[index].Find(key);
        }

        public NAW Delete(string key)
        {
            if (key == null) throw new ArgumentNullException();
            var index = KeyToIndex(key);
            var returnValue = logFiles[index].Delete(key);
            if (returnValue != null) count--;
            return returnValue;
        }


        public int Count => count;

        public double LoadFactor => (double)Count / Size;
    }
}
