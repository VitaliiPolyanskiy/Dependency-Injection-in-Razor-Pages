using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages;

public class IndexModel(IEnumerable<IMessageSender> sendersServices) : PageModel
{
    public string Message1 { get; private set; } = string.Join("", sendersServices.Select(service => $"<h1>{service.Send()}</h1>"));

    public string Message2 { get; private set; } = string.Empty;

    public void OnGet([FromServices] IMessageSender methodLevelMessageSender)
    {
        Message2 = methodLevelMessageSender.Send();
    }

    public string PrintTime()
    {
        var timeService = HttpContext.RequestServices.GetRequiredService<ITimeService>();
        return timeService.Time;
    }
}