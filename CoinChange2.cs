namespace CoinChange2
{
    public class Solution
    {
        public int Change(int amount, int[] coins)
        {
            int[] waysToMake = new int[amount + 1];
            waysToMake[0] = 1;
            foreach (int coin in coins)
            {
                for (int i = 0; i + coin <= amount; i++)
                {
                    waysToMake[i + coin] += waysToMake[i];
                }
            }
            return waysToMake[amount];
        }
    }
}