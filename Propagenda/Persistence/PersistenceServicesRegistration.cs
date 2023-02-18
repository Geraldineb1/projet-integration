using Application.Models.Identity;
using Application.Persistence.Contracts;
using Application.Persistence.Identity;
using Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Persistence.Repositories;
using Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PropagendaDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("PropagendaConnectionString"),
                        b => b.MigrationsAssembly(typeof(PropagendaDbContext).Assembly.FullName)));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IServiceReservationRepository, ServiceReservationRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IServiceTypeRepository, ServiceTypeRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<ITicketReservationRepository, TicketReservationRepository>();

            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            


            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<PropagendaDbContext>().AddDefaultTokenProviders();



            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IUserService, UserService>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        ValidIssuer = configuration["JwtSettings:Issuer"],
                        ValidAudience = configuration["JwtSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]))
                    };
                });


            return services;

        }
    }
}
