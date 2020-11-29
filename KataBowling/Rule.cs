namespace KataBowling
{
    static class Rule
    {
        public  static bool IsStrike(int firstThrowCount)
        {
            return firstThrowCount == 10;
        }

        public static bool IsSpare(int hitCount1, int hitCount2)
        {
            return hitCount1 + hitCount2 == 10;
        }

        public static bool IsDouble(Round currentRound, Round nextRound)
        {
            return currentRound.IsStrike && nextRound.IsStrike;
        }

        // 配列が0スタートなので1ずれる。
        public static bool Is1To8Round(int roundNum)
        {
            return roundNum >= 0 && roundNum <= 7;
        }

        public static bool IsSemiFinalRound(int roundNum)
        {
            return roundNum == 8;
        }

        public static bool IsFinalRound(int roundNum)
        {
            return roundNum == 9;
        }
    }
}
