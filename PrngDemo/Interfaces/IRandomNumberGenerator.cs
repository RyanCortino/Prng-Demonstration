namespace agRandom
{
    public interface IRandomNumberGenerator
    {
        public long GetSeed();
        public long GetLast();
        public long Next();
        public long Next(long maxValue);
        public string DemoResults(long maxValue, int resultsPerLine);
    }
}