using College360API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// PostgreSQL database connection
builder.Services.AddDbContext<College360DbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("College360Connection")
    )
);

// CORS - allow Angular frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AngularApp", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add controllers
builder.Services.AddControllers();

// Built-in OpenAPI support
builder.Services.AddOpenApi();

var app = builder.Build();

// OpenAPI document
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Enable CORS
app.UseCors("AngularApp");

app.UseAuthorization();

app.MapControllers();

app.Run();