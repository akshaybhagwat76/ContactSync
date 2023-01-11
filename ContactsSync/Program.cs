using ContactsSync.Database;
using ContactsSync.Helpers;
using ContactsSync.Interface;
using ContactsSync.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ContactsSyncContext>(c => c.UseSqlServer(builder.Configuration.GetConnectionString("SQLServer")));
builder.Services.AddAutoMapper(typeof(MappingProfiles));
builder.Services.AddScoped<IAllContracts, AllContractService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
