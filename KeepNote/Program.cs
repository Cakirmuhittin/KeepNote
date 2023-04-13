using KeepNoteAPI.Classes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(o=>o.AddDefaultPolicy(p=>p.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()));
// Add services to the container.
var cs = builder.Configuration.GetConnectionString("UygulamaDbContext");

builder.Services.AddDbContext<UygulamaDbContext>(o => o.UseSqlServer(cs));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthorization();

app.MapControllers();


app.Run();
