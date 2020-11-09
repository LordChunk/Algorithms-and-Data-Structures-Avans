using System;
using Alg1.Practica.Practicum6;
using Alg1.Practica.Utils.Models;

namespace Practicum6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var naw1 = new NAW("Hello", "address", "woonplaats");
            var naw2 = new NAW("Hello2", "address", "woonplaats");
            var naw3 = new NAW("Hello3", "address", "woonplaats");

            var queue = new NawPriorityQueue();

            queue.Enqueue(1, naw1);
            queue.Enqueue(2, naw2);
            queue.Enqueue(2, naw3);
            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine(queue.Count());

            Console.WriteLine("end");
        }
    }
}
