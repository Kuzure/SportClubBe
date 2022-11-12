using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using SportClub.Api;
using SportClub.Application.CQRS.Command;
using SportClub.Application.Interface;
using SportClub.Application.Repository;
using SportClub.Application.Validation;
using SportClub.Domain.Entity;
using SportClub.Persistance;
using System;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "SportClub", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

builder.Services.ConfigureSecurity(builder.Configuration);
builder.Services.AddCustomCors(builder.Configuration);
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<SportClubDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("SportClubDb"),
    x => x.MigrationsAssembly("SportClub.Persistance")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddMediatR(typeof(RegisterUserCommand).Assembly);

builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>))
    .AddTransient<IUserRepository, UserRepository>()
    .AddTransient<ICompetitorRepository, CompetitorRepository>()
    .AddTransient<IGroupRepository,GroupRepository>();

builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
builder.Services.AddScoped<IPasswordHasher<Competitor>, PasswordHasher<Competitor>>();

builder.Services.AddScoped<IValidator<RegisterUserCommand>, RegisterValidation>();

builder.Services.AddFluentValidationAutoValidation();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.UseCors("AllowedHosts");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
