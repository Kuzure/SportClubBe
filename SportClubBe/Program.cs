using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SportClub.Api;
using SportClub.Api.Interface;
using SportClub.Api.Repository;
using SportClubBe.Entity;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.ConfigureSecurity(builder.Configuration);
builder.Services.AddCustomCors(builder.Configuration);
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<SportClubDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("SportClubDb")));

builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>))
    .AddTransient<IUserRepository, UserRepository>();
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();



builder.Services.AddControllers().AddFluentValidation(options => {
    options.ImplicitlyValidateChildProperties = true;
    options.ImplicitlyValidateRootCollectionElements = true;
    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});

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
