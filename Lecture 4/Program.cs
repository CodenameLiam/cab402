using System;

namespace Lecture_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // List form
            System.Console.WriteLine("List form");
            var list = new System.Collections.Generic.List<int> { 1, 3, 6 };
            foreach (var i in list)
            {
                System.Console.WriteLine(i);
            }

            // Enumerable form 
            System.Console.WriteLine("\nEnumerable form");
            System.Collections.Generic.IEnumerator<int> seq = list.GetEnumerator();
            while (seq.MoveNext())
            {
                System.Console.WriteLine(seq.Current);
            }

            
                
        }
    }
}
