var builder = WebApplication.CreateBuilder(args);
var MyAllowedOrigins = "_myCORS";

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<IWebHostEnvironment>();
builder.Services.AddDirectoryBrowser();

builder.Services.AddCors(options => {
    options.AddPolicy(name: MyAllowedOrigins,
            policy =>
            {
                policy.WithOrigins("http://localhost:3000",
                    "http://localhost:3001",
                    "http://123.31.24.17:3000",
                    "http://123.31.24.17:3001",
                    "http://14.231.100.236:3000",
                    "http://14.231.100.236:3001",
                    "http://14.231.100.236:13390")
                 .AllowAnyHeader()
                 .AllowAnyMethod()
                 .AllowCredentials();
            });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseCors(MyAllowedOrigins);
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();