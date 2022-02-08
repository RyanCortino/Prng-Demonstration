using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using agRandom;

public class RngService : BaseDemoService
{
    protected readonly IRandomNumberGenerator _rng;

    public RngService(ILogger<BaseDemoService> log, IConfiguration config) 
        : base(log, config)
    {
        // Initialize the number generator
        _rng = new Lcg();
    }

    public override void Run()
    {
        _log.LogInformation("RngService Running: Seed: {0}", _rng.GetSeed());

        // Let's run 10 passes for the sake of demonstration
        for (int i = 0; i < 10; i++)
        {
            _log.LogInformation("Pass {0}, result= {1}", i, _rng.DemoResults(maxValue: 10, resultsPerLine: 10));
        }
    }
}
