using LMS_API.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var MyAllowedOrigins = "_myCORS";


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LMSContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Infor")));
builder.Services.AddCors(options => {
    options.AddPolicy(name: MyAllowedOrigins,
            policy =>
            {
                policy.WithOrigins("http://localhost:3001")
                 .AllowAnyHeader()
                 .AllowAnyMethod()
                 .AllowCredentials();
            });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyAllowedOrigins);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();