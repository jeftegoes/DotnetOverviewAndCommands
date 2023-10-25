using System.Net;
using WorkerWithWebapi;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<Worker>();

var app = builder.Build();

app.MapGet("/health", async () => new HttpResponseMessage(HttpStatusCode.OK));

app.Run();
