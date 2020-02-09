namespace ScoreOfParentheses
{
    class Solution
    {
        private int pos = 0;
        private string sGood;
        public int ScoreOfParentheses(string S)
        {
            pos = 0;
            if (S.Length == 0) return 0;
            sGood = S.Replace("()", "1");
            return ScoreLevel();
        }
        private int ScoreLevel() {
            int retVal = 0;
            while (pos < sGood.Length) {
                if(sGood[pos] == '1') {
                    pos++;
                    retVal++;
                }
                else if(sGood[pos] == '(') {
                    pos++;
                    retVal += 2 * ScoreLevel();
                }
                else if(sGood[pos] == ')') {
                    pos++;
                    return retVal;
                }
            }

            return retVal;
        }
    }
}