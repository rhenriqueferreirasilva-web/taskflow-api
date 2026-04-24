var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/tasks", () =>
{
    return new[]
    {
        new { Id = 1, Title = "Estudar C#", Done = false },
        new { Id = 2, Title = "Criar API", Done = true }
    };
});

app.Run();
