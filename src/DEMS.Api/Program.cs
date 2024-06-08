using DEMS.ApiLibrary.Data;
using DEMS.ApiLibrary.Helpers;
using DEMS.ApiLibrary.Repositories.Contracts;
using DEMS.ApiLibrary.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Starting
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? 
        throw new InvalidOperationException("Sorry, your connection is not found!"));
});

builder.Services.Configure<JwtSection>(builder.Configuration.GetSection("JwtSection"));
builder.Services.AddScoped<IUserAccount, UserAccountRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorWasm",
        builder => builder
        .WithOrigins("http://localhost:5198", "https://localhost:7034")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});

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
