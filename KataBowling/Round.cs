namespace KataBowling
{
    class Round
    {
        public int Num { get; set; }
        public Round(int currentRoundNum, int[] counts)
        {
            Num = currentRoundNum;
            FirstThrowCount = counts[0];
            SecondThrowCount = counts[1];
            if (counts.Length == 3) ThirdThrowCount = counts[2];
        }
        public bool IsStrike => Rule.IsStrike(FirstThrowCount);

        public bool IsSpare => Rule.IsSpare(FirstThrowCount, SecondThrowCount);

        public bool IsFinalRound => Rule.IsFinalRound(Num);

        public bool Is1To8Round => Rule.Is1To8Round(Num);

        public bool Is9Round => Rule.IsSemiFinalRound(Num);

        public int FirstThrowCount { get; set; }

        public int SecondThrowCount { get; set; }

        public int ThirdThrowCount { get; set; } = 0;

        public int TotalHitCount()
        {
            return FirstThrowCount + SecondThrowCount;
        }
    }
}
