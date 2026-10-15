namespace DependencyInjection.Services;

public class EmailMessageSender : IMessageSender
{
    public string Send() => "Надіслано електронною поштою";
}