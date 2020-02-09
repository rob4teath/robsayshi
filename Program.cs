using System.Collections.Generic;
using System;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            TrappingRainWater();
            CoinChange2();
            KeysAndRooms();
            ScoreOfParentheses();
        }
        
        static void TrappingRainWater() {
            Console.WriteLine("42. Trapping Rain Water");
            var testObj = new TrappingRainWater.Solution();
            Console.WriteLine(testObj.Trap(new int[]{0,1,0,2,1,0,1,3,2,1,2,1}));
        }

        static void CoinChange2() {
            Console.WriteLine("518. Coin Change 2");
            var testObj = new CoinChange2.Solution();
            Console.WriteLine(testObj.Change(10, new int[]{2, 3}));
            Console.WriteLine(testObj.Change(500, new int[]{3, 5, 7, 8, 9, 10, 11}));
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
