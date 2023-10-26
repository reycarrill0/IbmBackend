﻿using Algar.Hours.Application.DataBase;
using Algar.Hours.Persistence.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Algar.Hours.External
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddExternal(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddDbContext<DatabaseService>(options =>
            //options.UseSqlServer(configuration["SQLConnectionStrings"]));

            services.AddDbContext<DatabaseService>(options => 
            options.UseNpgsql(configuration["SQLConnectionStringsPost"]));
            

            services.AddScoped<IDataBaseService, DatabaseService>();

            return services;
        }
    }
}
