using System.IO;
using System.Net;
using System.Threading.Tasks;
using DfE.Hexagonal.Application.UseCases.School.CreateSchool;
using DfE.Hexagonal.Application.UseCases.School.GetAllSchools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace DfE.Hexagonal.FunctionApp.Triggers.GetAllSchools
{
    public class GetAllSchools
    {
        private readonly ILogger<GetAllSchools> _logger;
        private readonly IGetAllSchools _getAllSchools;

        public GetAllSchools(
            ILogger<GetAllSchools> log, 
            IGetAllSchools getAllSchools)
        {
            _logger = log;
            _getAllSchools = getAllSchools; 
        }

        [FunctionName("GetAllSchools")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "name" })]
        [OpenApiSecurity("function_key", SecuritySchemeType.ApiKey, Name = "code", In = OpenApiSecurityLocationType.Query)]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "application/json", bodyType: typeof(GetAllSchoolsOutput), Description = "All known schools")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.BadRequest,
                                   Summary = "Invalid parameters",
                                   Description = "Either Invalid parameters or parameters are missing")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req)
        {
            _logger.LogInformation("GetAllSchoolsFunction processed a request.");

            var result = await _getAllSchools.Handle();
            return new OkObjectResult(result.Schools);
        }
    }
}

