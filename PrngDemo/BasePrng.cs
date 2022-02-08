namespace agRandom
{
    public abstract class BasePrng : IRandomNumberGenerator
    {
        protected readonly long _seed;

        public long GetSeed() => _seed;
        public long Next() => GenerateNext();

        public BasePrng(long seed) 
        {
            _seed = seed;
        }

        protected abstract long GenerateNext();
    }
}