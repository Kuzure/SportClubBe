using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace SportClub.Api
{
    public static class AuthExtension
    {
        public static void AddCustomCors(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(opt => opt.AddPolicy("AllowedHosts", builder =>
            {
                var allowedHosts = configuration.GetSection("CorsConfiguration:AllowedHosts").Get<string[]>();
                builder.WithOrigins(allowedHosts).AllowAnyHeader().AllowAnyMethod();
            }));
        }

        public static void ConfigureSecurity(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(builder =>
            {
                var key = Encoding.UTF8.GetBytes(configuration.GetSection("JWTConfiguration:SecretKey").Get<string>());
                builder.SaveToken = true;
                builder.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = configuration.GetSection("JWTConfiguration:Issuer").Get<string>(),
                    ValidAudience = configuration.GetSection("JWTConfiguration:Audience").Get<string>(),
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
            });
            services.AddAuthorization();

        }

    }
}

