using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;

namespace Leetcode
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, ExpectedResult = 6)]
        public int TrappingRainWaterTest(int[] height)
        {
            var testObj = new TrappingRainWater.Solution();
            return testObj.Trap(height);
        }

        [Test]
        [TestCase(10, new int[] { 2, 3 }, ExpectedResult = 2)]
        [TestCase(500, new int[] { 3, 5, 7, 8, 9, 10, 11 }, ExpectedResult = 35502874)]
        public int CoinChange2Test(int amount, int[] coins)
        {
            var testObj = new CoinChange2.Solution();
            return testObj.Change(amount, coins);
        }

        [Test]
        public void KeysAndRoomsTest()
        {
            var keys = new List<IList<int>>();
            keys.Add(new List<int>() { 1, 3 });
            keys.Add(new List<int>() { 3, 2, 1 });
            keys.Add(new List<int>() { 2 });
            keys.Add(new List<int>() { });
            var testObj = new KeysAndRooms.Solution();
            Assert.IsTrue(testObj.CanVisitAllRooms(keys));
        }

        [Test]
        [TestCase("()", ExpectedResult = 1)]
        [TestCase("(())", ExpectedResult = 2)]
        [TestCase("()()", ExpectedResult = 2)]
        [TestCase("(())()", ExpectedResult = 3)]
        public int ScoreOfParenthesesTest(string input)
        {
            var testObj = new ScoreOfParentheses.Solution();
            return testObj.ScoreOfParentheses(input);
        }
    }
}