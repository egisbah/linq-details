using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDetails
{
    class Program
    {
        static void Main()
        {
            var source = new List<string>() { "hi", "lol", "insanguination", "bye" , "Nebuchadnezzar" };

            var linqResult = source
                .Where(n => n.Length > 10)
                .Select(n => n.ToUpper());

            var listFilter = MoreThanFive(source);
            var listMap = AddTen(listFilter);

            source.Add("defenestration");

            Print(linqResult);
            Print(listMap);
        }

        private static IEnumerable<string> MoreThanFive(IEnumerable<string> collection)
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<string> AddTen(IEnumerable<string> collection)
        {
            throw new NotImplementedException();
        }

        private static void Print(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
