using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IMessageSender, SmsMessageSender>();
builder.Services.AddScoped<ITimeService, SimpleTimeService>();

var app = builder.Build();

app.UseStaticFiles();

app.MapRazorPages();

app.Run();
