using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Application.UseCases.School.GetAllSchools
{
    public class GetAllSchoolsOutput
    {
        public IEnumerable<SchoolOutput> Schools { get; }

        public GetAllSchoolsOutput(IEnumerable<SchoolOutput> schools)
        {
            Schools = schools;
        }
    }
}
