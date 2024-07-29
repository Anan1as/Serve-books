using Microsoft.EntityFrameworkCore;
using Serve_books.Services.Interface;
using Serve_books.Services.Repository;
using Servebooks.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options =>
								options.UseMySql(
									builder.Configuration.GetConnectionString("MySqlConnection"),
									ServerVersion.Parse("8.0.20-mysql")));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICorreoRepository, CorreoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.MapControllers();

app.Run();
