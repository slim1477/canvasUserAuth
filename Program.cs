using MemberVerify;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Allow CORS
builder.Services.AddCors();

// add documentation to swagger via xml
builder.Services.AddSwaggerGen(doc =>
{
    doc.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Member verification API", Version = "v1" });
    doc.IncludeXmlComments(Path.Combine(System.AppContext.BaseDirectory, "MemberVerifyApiDoc.xml"));
    doc.MapType<DateOnly>(() => new OpenApiSchema
    {
        Type = "string",
        Format = "date"
    });
});

// configure MemberVerify application for dependency injection
builder.Services.AddScoped<IMemberRepo,MemberRepo>();
builder.Services.AddScoped<IAccountRepo, AccountRepo>();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
