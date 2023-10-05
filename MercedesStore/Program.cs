using MercedesStore.Application;
using MediatR;
using MercedesStore.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Formatters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(config =>
{
    config.RespectBrowserAcceptHeader = true;
    config.ReturnHttpNotAcceptable = true;
})
    //.AddNewtonsoftJson(c=>c.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
    .AddApplicationPart(typeof(MercedesStore.Presentation.AssemblyReference).Assembly);
builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureRepositoryManager();
builder.Services.AddMediatR(typeof(AssemblyReference).Assembly);
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.ConfigureSwagger();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.ConfigureExceptionHandler();
app.UseHttpsRedirection();

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mercedes Store API"));
app.Run();


NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter() => new ServiceCollection().AddLogging()
    .AddMvc().AddNewtonsoftJson().Services.BuildServiceProvider()
    .GetRequiredService<IOptions<MvcOptions>>().Value.InputFormatters
    .OfType<NewtonsoftJsonPatchInputFormatter>().First();