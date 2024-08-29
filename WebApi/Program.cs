using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebApi.shared.appDbContext;
using WebApi.shared.mapping;
using AspNet.Scalar;
using WebApi.shared.filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
    // Configurar para não gerar esquemas para tipos genéricos
    // var cont = 0;
    // c.CustomSchemaIds(type =>
    // {
    //     if (type.FullName.StartsWith("WebApi"))
    //     {   
    //         return type.FullName.Split(".").Last();
    //     }
    //
    //     cont++;
    //     return $"id{cont}";
    // });
    // c.SchemaFilter<SwaggerSchemaFilter>();
});

builder.Services.AddAutoMapper(typeof(MappingProfile));


var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
var dbPath = Path.Combine(baseDirectory, "app.db");
Console.WriteLine(dbPath);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

var app = builder.Build();


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