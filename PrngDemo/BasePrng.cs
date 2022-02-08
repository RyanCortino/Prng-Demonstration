namespace agRandom
{
    public abstract class BasePrng : IRandomNumberGenerator
    {
        protected readonly long _seed;
        protected long _last;

        public long GetSeed() => _seed;
        public long GetLast() => _last;

        public BasePrng(long seed) 
        {
            _seed = seed;
            _last = seed;
        }

        public abstract long Next();
        public abstract long Next(long maxValue);
        public abstract string DemoResults(long maxValue, int resultsPerLine);
    }
}