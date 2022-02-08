using System;

namespace agRandom
{
    public class Lcg : BasePrng
    {
        public Lcg() : base(seed: DateTime.Now.Ticks) { }
        public Lcg(long seed) : base(seed) { }

        protected override long GenerateNext()
        {
            throw new NotImplementedException();
        }
    }
}