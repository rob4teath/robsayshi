using System.Collections.Generic;
using System;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            KeysAndRooms();
            ScoreOfParentheses();
        }
        static void KeysAndRooms()
        {
            Console.WriteLine("841. Keys And Rooms");
            var keys = new List<IList<int>>();
            keys.Add(new List<int>() { 1, 3 });
            keys.Add(new List<int>() { 3, 2, 1 });
            keys.Add(new List<int>() { 2 });
            keys.Add(new List<int>() { });
            var testObj = new KeysAndRooms.Solution();
            Console.WriteLine(testObj.CanVisitAllRooms(keys));
        }

        static void ScoreOfParentheses()
        {
            Console.WriteLine("856. Score Of Parentheses");
            var testObj = new ScoreOfParentheses.Solution();
            Console.WriteLine(testObj.ScoreOfParentheses("()"));
            Console.WriteLine(testObj.ScoreOfParentheses("(())"));
            Console.WriteLine(testObj.ScoreOfParentheses("()()"));
            Console.WriteLine(testObj.ScoreOfParentheses("(())()"));
        }


    }
}
