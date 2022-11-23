using DfE.Hexagonal.Application.Shared.Repositories;
using DfE.Hexagonal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Application.UseCases.School.GetAllSchools
{
    public class GetAllSchools : IGetAllSchools
    {
        private readonly ISchoolRepository _schoolRepository;

        public GetAllSchools(ISchoolRepository repository)
        {
            _schoolRepository = repository;
        }

        public async Task<GetAllSchoolsOutput> Handle()
        {
            var schools = _schoolRepository.GetAll();

            var output = schools.Select(s => SchoolOutput.MapOutput(s));

            return new GetAllSchoolsOutput(output);
        }
    }
}
