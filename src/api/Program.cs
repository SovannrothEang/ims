using api;
using api.Endpoints;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
// Add DI
builder.Services.AddServiceCollection(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "IMS");
    });
    app.MapScalarApiReference();
}
app.UseExceptionHandler();
app.MapApiEndpoints();

app.Run();