using DfE.Hexagonal.Application.UseCases.School.CreateSchool;
using DfE.Hexagonal.Application.UseCases.School.GetAllSchools;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.FunctionApp.Extensions
{
    public static class UseCaseExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateSchool, CreateSchool>();
            services.AddScoped<IGetAllSchools, GetAllSchools>();

            return services;
        }
    }
}
