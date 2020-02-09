using System.Collections.Generic;
using System;

namespace robsayshi
{
    class Program
    {
        static void Main(string[] args)
        {
            var keys = new List<IList<int>>();
            keys.Add(new List<int>() { 1, 3 });
            keys.Add(new List<int>() { 3, 2, 1 });
            keys.Add(new List<int>() { 2 });
            keys.Add(new List<int>() { });
            var testObj = new Solution();
            Console.WriteLine(testObj.CanVisitAllRooms(keys));
        }
    }
}
