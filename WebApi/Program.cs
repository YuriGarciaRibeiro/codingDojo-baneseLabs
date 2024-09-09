using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebApi.shared.appDbContext;
using WebApi.shared.mapping;
using AspNet.Scalar;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(80);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder => builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
});

builder.Services.AddAutoMapper(typeof(MappingProfile));


var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
var dbPath = Path.Combine(baseDirectory, "app.db");
Console.WriteLine(dbPath);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

var app = builder.Build();
app.UseCors("AllowAll");

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseScalar(option =>
{
    option.UseTheme(Theme.DeepSpace);
    option.RoutePrefix = "scalar";
});

app.Run();