using System.IO;
using System.Net;
using System.Threading.Tasks;
using DfE.Hexagonal.Application.UseCases.School.CreateSchool;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace DfE.Hexagonal.FunctionApp.Triggers.CreateSchool
{
    public class CreateSchoolFunction
    {
        private readonly ILogger<CreateSchoolFunction> _logger;
        private readonly ICreateSchool _createSchool;
        public CreateSchoolFunction(
            ILogger<CreateSchoolFunction> log,
            ICreateSchool createSchool)
        {
            _logger = log;
            _createSchool = createSchool;
        }

        [FunctionName("CreateSchoolFunction")]
        [OpenApiOperation(operationId: "create-school",
            tags: new[] { "Create new School" },
            Summary = "Creates a new school based on the details given",
            Description = "Need to submit list of UPNs or searchText with optional filters, index type and query type",
            Visibility = OpenApiVisibilityType.Important)]
        [OpenApiRequestBody("input", typeof(SchoolInput))]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.Created, contentType: "text/plain", bodyType: typeof(SchoolInput), Description = "The details of the school created")]
        [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.BadRequest,
                                   Summary = "Invalid parameters",
                                   Description = "Either Invalid parameters or parameters are missing")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = Routes.School)] HttpRequest req)
        {
            _logger.LogInformation("CreateSchoolFunction processed a request.");

            string input = await new StreamReader(req.Body).ReadToEndAsync();
            var schoolInput = JsonConvert.DeserializeObject<SchoolInput>(input);

            var response = await _createSchool.Handle(schoolInput);
            if (response.Success)
            {
                return new CreatedResult("", schoolInput);
            }
            else
            {
                return new BadRequestObjectResult(response.Errors);
            }
        }
    }
}