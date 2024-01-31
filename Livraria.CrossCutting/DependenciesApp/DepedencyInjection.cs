using Livaria.Domain.Abstractions;
using Livaria.Infrastructure.Context;
using Livaria.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.CrossCutting.DependenciesApp
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            var connectionString = configuration.GetConnectionString("Sqlite");

            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite(connectionString));

            services.AddScoped<ILivroRepository, LivroRepository>();

            return services;
        }
    }
}
