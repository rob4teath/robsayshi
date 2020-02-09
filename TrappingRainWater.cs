using System;
using System.Collections.Generic;
namespace TrappingRainWater
{
    using System.Collections;
    public class Solution
    {
        internal class HighPoint
        {
            public HighPoint(int pos, int h)
            {
                position = pos;
                height = h;
            }
            public int position;
            public int height;
        }
        public int Trap(int[] height)
        {
            if (height.Length <= 2) return 0;
            int retVal = 0;
            int leftMax = 0;
            int curPos = 0;
            var leftHighPoints = new Stack<HighPoint>();
            leftHighPoints.Push(new HighPoint(-1, 0));
            for (curPos = 0; curPos < height.Length; curPos++)
            {
                if (height[curPos] > leftMax)
                {
                    leftMax = height[curPos];
                    leftHighPoints.Push(new HighPoint(curPos, leftMax));
                }
            }
            var highToLeft = leftHighPoints.Pop();
            var rightMax = height[--curPos];
            while (highToLeft.height > 0 && curPos > 0)
            {
                while (curPos >= highToLeft.position)
                {
                    if (height[curPos] > rightMax)
                    {
                        rightMax = height[curPos];
                    }
                    retVal += Math.Min(highToLeft.height, rightMax) - height[curPos];
                    curPos--;
                }
                highToLeft = leftHighPoints.Pop();
            }

            return retVal;
        }
    }
}