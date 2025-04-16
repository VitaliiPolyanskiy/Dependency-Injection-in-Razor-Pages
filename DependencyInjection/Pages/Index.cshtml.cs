using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        public string Message1 { get; private set; } = "";
        public string Message2 { get; private set; } = "";

        public IndexModel(IMessageSender MessageSender)
        {
            Message1 = MessageSender.Send();
        }

        public void OnGet([FromServices] IMessageSender MessageSender)
        {
            Message2 = MessageSender.Send();
        }

        public string PrintTime()
        {
            var timeService = HttpContext.RequestServices.GetService<ITimeService>();
            return timeService.Time;
        }
    }
}