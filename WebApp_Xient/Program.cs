using Microsoft.EntityFrameworkCore;
using WebApp_Xient.Contexts;
using WebApp_Xient.Repositories;
using WebApp_Xient.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ArticleContext>(x =>
    x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));

builder.Services.AddScoped<ArticleService>();
builder.Services.AddScoped<ArticleRepository>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
