var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Zaaas!");

app.Run();

void Teste()
{

}
