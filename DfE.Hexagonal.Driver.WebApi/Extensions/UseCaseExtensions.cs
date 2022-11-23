using DfE.Hexagonal.Application.UseCases.School.CreateSchool;
using DfE.Hexagonal.Application.UseCases.School.GetAllSchools;
using DfE.Hexagonal.Common;

namespace DfE.Hexagonal.Driver.WebApi.Extensions
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
