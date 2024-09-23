var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var apellido = builder.Configuration.GetValue<string>("apellido");

app.MapGet("/", () => apellido);

app.Run();
