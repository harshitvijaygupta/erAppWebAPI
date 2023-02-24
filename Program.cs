using Microsoft.EntityFrameworkCore;
using erRelnAPI.Models;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddSession(); // for login

builder.Services.AddCors();

// builder.Services.AddApiVersioning();

builder.Services.AddDbContext<Ace42023Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

//added for logout
// builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

JsonConvert.SerializeObject(System.Xml.Formatting.Indented,
new JsonSerializerSettings{
    ReferenceLoopHandling = ReferenceLoopHandling.Serialize
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseSession(); // for login session

// app.UseApiVersioning();
app.UseCors(options=>options.WithOrigins("http://localhost:4200/").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
