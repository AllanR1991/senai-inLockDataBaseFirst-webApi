using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .AddNewtonsoftJson(options =>
    {
        // Ignora os loopings nas consultas
        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        // Ignora valores nulos ao fazer jun��es nas consultas
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
    });

var app = builder.Build();

app.MapControllers();

app.Run();
