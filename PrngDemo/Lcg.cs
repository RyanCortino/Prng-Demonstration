using System;

namespace agRandom
{
    /// <summary>
    /// Linear Congruential Generator (LCG)
    /// <variables>
    ///     Modulus: long m
    ///         The maximum period of the pseudo-random number sequence.
    ///             Thus we choose m to be close to the maximum integer number
    ///             representable in a single register.
    ///     Multiplier: long a
    ///     Increment: long c
    ///         the parameters a and c should be relatively prime to m. 
    /// </variables>
    /// </summary>
    public class Lcg : BasePrng
    {
        private const long m = 4294967296;  // 2^32
        private const long a = 1664525;
        private const long c = 1012904223;

        public Lcg() : base(seed: DateTime.Now.Ticks % m) { }
        public Lcg(long seed) : base(seed) { }

        public override long Next()
        {
            _last = (a * _last + c) % m;
            return _last;
        }

        public override long Next(long maxValue)
        {
            return Next() % maxValue;
        }

        public override string DemoResults(long maxValue, int resultsPerLine)
        {
            string returnValue = "";

            // Showing 10 results per line for easier viewing in the console window.
            for (int j = 0; j < resultsPerLine; j++)
            {
                returnValue += Next(maxValue);
                if (j < resultsPerLine-1)
                    returnValue += ", ";
            }

            return returnValue;
        }
    }
}