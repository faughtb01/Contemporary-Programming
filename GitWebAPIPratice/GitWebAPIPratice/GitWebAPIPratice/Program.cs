// Brian Faught
// 10/31/2024
var builder = WebApplication.CreateBuilder(args);

//  services.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//  HTTP request .
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

Console.WriteLine($"Application starting on: {app.Urls.FirstOrDefault()}");

app.Run();