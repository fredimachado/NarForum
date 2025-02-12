﻿using Api.Middleware;
using Application.Extensions;
using Persistence.Extensions;
using Identity.Extensions;
using Identity.Hubs;
using Microsoft.AspNetCore.WebSockets;
using Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Identity.DatabaseContext;

var builder = WebApplication.CreateBuilder(args);
// add NarForum.ServiceDefaults to Api project
builder.AddServiceDefaults();

builder.Services.AddSignalR(options =>
{
    options.KeepAliveInterval = TimeSpan.FromSeconds(10); 
    options.ClientTimeoutInterval = TimeSpan.FromSeconds(20);
});

// Add services to the container.
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddWebSockets(o => { 
    o.AllowedOrigins.Add("https://localhost:7058");
    o.AllowedOrigins.Add("https://localhost:7212");
    o.AllowedOrigins.Add("http://localhost:5081/");
    o.AllowedOrigins.Add("https://narforum.com");
    o.AllowedOrigins.Add("https://admin.narforum.com");
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("all", builder => builder
        .WithOrigins("https://localhost:7058", "https://localhost:7212", "http://localhost:5081/", "https://narforum.com", "https://admin.narforum.com")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()  
        .SetIsOriginAllowed((host) => true)
    );

    options.AddPolicy("AllowAllOriginsForImages",
            builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });

    options.AddPolicy("AllowAllOriginsForFiles",
            builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
});

builder.Services.AddHttpContextAccessor();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


app.UseMiddleware<ExceptionMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();



if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    try
    {




        using (var scope = app.Services.CreateScope())
        {



            using (var dbContext = scope.ServiceProvider.GetRequiredService<ForumIdentityDbContext>())
            {
                if (dbContext.Database.GetPendingMigrations().Any())
                {
                    dbContext.Database.Migrate();
                }
            }

            using (var dbContext = scope.ServiceProvider.GetRequiredService<ForumDbContext>())
            {
                if (dbContext.Database.GetPendingMigrations().Any())
                {
                    dbContext.Database.Migrate();
                }
            }
        }
    }
    catch (Exception ex)
    {
        throw new InvalidOperationException("Database migration failed.", ex);
    }
}
else
{
    try
    {
        using (var scope = app.Services.CreateScope())
        {
            using (var dbContext = scope.ServiceProvider.GetRequiredService<ForumIdentityDbContext>())
            {
                if (dbContext.Database.GetPendingMigrations().Any())
                {
                    dbContext.Database.Migrate();
                }
            }

            using (var dbContext = scope.ServiceProvider.GetRequiredService<ForumDbContext>())
            {
                if (dbContext.Database.GetPendingMigrations().Any())
                {
                    dbContext.Database.Migrate();
                }
            }
        }
    }
    catch (Exception ex)
    {
        throw new InvalidOperationException("Database migration failed.", ex);
    }
}

app.MapHub<TrackHub>("track", o => { 
    o.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets;
});

app.MapHub<ChatHub>("chat", o => {
    o.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets;
});

app.MapHub<NotificationHub>("notification", o => {
    o.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets;
});

app.UseCors("all");
app.UseWebSockets();

app.UseAuthentication();
app.UseAuthorization();
app.UseDeveloperExceptionPage();

app.MapControllers();

app.MapDefaultEndpoints();

app.Run();