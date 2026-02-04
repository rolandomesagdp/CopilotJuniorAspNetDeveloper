using CopilotJuniorAspNetDeveloper.Application.Persons;
using CopilotJuniorAspNetDeveloper.Infrastructure.Context;
using CopilotJuniorAspNetDeveloper.Infrastructure.Persons;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("CopilotJuniorAspNetDeveloperDb");
builder.Services.AddDbContext<CopilotJuniorAspNetDeveloperDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IPersonsRepository, PersonsRepository>();
builder.Services.AddScoped<RetrieveAllPersonsHandler>();
builder.Services.AddScoped<RetrievePersonByIdHandler>();

builder.Services.AddControllers();

builder.Services.AddOpenApi();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;
    var context = service.GetService<CopilotJuniorAspNetDeveloperDbContext>();
    await DbInitializer.InitializeDb(context);
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
