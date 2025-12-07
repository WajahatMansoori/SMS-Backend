using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SMS.Domain.Repository;
using SMS.Infrastructure.Data;
using SMS.Infrastructure.Repository;

namespace SMS.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<SmsDbContext>(options =>
                 options.UseSqlServer(connectionString));


            services.AddScoped<IClassRepository, ClassRepository>();

            return services;
        }
    }
}
