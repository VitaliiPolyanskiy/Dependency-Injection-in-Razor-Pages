using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

// Додаємо сервіси Razor Pages
builder.Services.AddRazorPages();

// Реєструємо сервіси у контейнері залежностей
builder.Services.AddScoped<IMessageSender, EmailMessageSender>();
builder.Services.AddScoped<IMessageSender, SmsMessageSender>();
builder.Services.AddScoped<ITimeService, SimpleTimeService>();

var app = builder.Build();

app.UseStaticFiles();

app.MapRazorPages();

app.Run();