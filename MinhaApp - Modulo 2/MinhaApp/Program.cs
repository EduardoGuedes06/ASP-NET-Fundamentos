using Blog.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<BlogDataContext>();
var app = builder.Build();

app.MapGet("/", () => "Ontem Eu Brinquei com meus brinquedos");
app.MapControllers();

app.Run();
