using MemberVerify.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// add documentation to swagger via xml
builder.Services.AddSwaggerGen(doc =>
{
    doc.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Member verification API", Version = "v1" });
    doc.IncludeXmlComments(Path.Combine(System.AppContext.BaseDirectory, "MemberVerifyApiDoc.xml"));
});

// configure MemberVerify application for dependency injection
builder.Services.AddScoped<IMemberVerifyRepo,MemberVerifyRepo>();

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
