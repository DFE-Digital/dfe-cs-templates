using DfE.Hexagonal.Application.UseCases.School.CreateSchool;
using DfE.Hexagonal.Application.UseCases.School.GetAllSchools;
using DfE.Hexagonal.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DfE.Hexagonal.Driver.WebApi.Controllers
{
    /// <summary>
    /// You can put all the use cases for a particular endpoint in here using HTTP verbs, i.e.
    /// 
    /// GET /school/{id} - for fetching one school
    /// GET /school?offset=0&limit=10 - for fetching multiple
    /// PUT /school - for create
    /// POST /school - for upsert
    /// DELETE /school/{id} - for delete
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ICreateSchool _createSchool;
        private readonly IGetAllSchools _getAllSchools;

        public SchoolController(ICreateSchool createSchool, IGetAllSchools getAllSchools)
        {
            _createSchool = createSchool;
            _getAllSchools = getAllSchools;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SchoolInput school)
        {
            var response = await _createSchool.Handle(school);
            if (response.Success)
            {
                return Created("", school);
            }
            else
            {
                return BadRequest(response.Errors);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _getAllSchools.Handle();
            return Ok(result.Schools);
        }
    }
}
