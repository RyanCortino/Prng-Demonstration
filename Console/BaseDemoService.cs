using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public abstract class BaseDemoService : IService
{
    protected readonly ILogger<BaseDemoService> _log;
    protected readonly IConfiguration _config;

    public BaseDemoService(ILogger<BaseDemoService> log, IConfiguration config)
    {
        _log = log;
        _config = config;
    }

    public abstract void Run();        
}