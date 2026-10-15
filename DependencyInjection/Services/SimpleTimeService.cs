namespace DependencyInjection.Services;

public class SimpleTimeService : ITimeService
{
    public string Time => DateTime.Now.ToString("HH:mm:ss");
}