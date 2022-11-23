using DfE.Hexagonal.Application.Shared.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Driven.InMemory
{
    public static class InMemoryServiceCollectionExtensions
    {
        public static IServiceCollection AddInMemoryRepositories(this IServiceCollection services)
        {
            services.AddSingleton<InMemoryContext>();

            services.AddScoped<ISchoolRepository, SchoolRepository>();

            return services;
        }
    }
}
