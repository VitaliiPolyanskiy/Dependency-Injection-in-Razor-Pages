namespace DependencyInjection.Services;

public class SmsMessageSender : IMessageSender
{
    public string Send() => "Надіслано через SMS";
}