using Alg1.Practica.Utils;
using Alg1.Practica.Utils.Models;
using System;


namespace Alg1.Practica.Practicum7
{
    public class LogFile : INawDictionary
    {
        protected LogFileLink Head { get; set; }

        public virtual void Insert(string key, NAW value)
        {
            if (key == null) throw new ArgumentNullException();

            Head = new LogFileLink(key, value, Head);
        }

        public virtual NAW Find(string key)
        {
            if (key == null) return null;

            var logFile = Head;
            do
            {
                if (logFile.Key == key) return logFile.Value;
                logFile = logFile.Next;
            } while (logFile != null);

            return null;
        }

        public virtual NAW Delete(string key)
        {
            if (key == null) return null;

            var logFile = Head;

            if (logFile.Key == key)
            {
                var returnValue = logFile.Value;
                Head = Head.Next;
                return returnValue;
            }
            
            do
            {
                if (logFile.Next.Key == key)
                {
                    var returnValue = logFile.Next.Value;

                    logFile.Next = logFile.Next.Next;

                    return returnValue;
                }

                logFile = logFile.Next;
            } while (logFile != null);

            return null;
        }
    }

}
