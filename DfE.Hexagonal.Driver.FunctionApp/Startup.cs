using DfE.Hexagonal.Driven.InMemory;
using DfE.Hexagonal.FunctionApp;
using DfE.Hexagonal.FunctionApp.Extensions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: FunctionsStartup(typeof(Startup))]
namespace DfE.Hexagonal.FunctionApp
{
    [ExcludeFromCodeCoverage]
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddUseCases();
            builder.Services.AddInMemoryRepositories();
        }
    }
}
