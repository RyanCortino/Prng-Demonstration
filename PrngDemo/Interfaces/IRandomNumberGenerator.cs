namespace agRandom
{
    public interface IRandomNumberGenerator
    {
        public long GetSeed();
        public long Next();
    }
}