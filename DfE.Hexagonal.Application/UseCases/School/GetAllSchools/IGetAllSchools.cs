using DfE.Hexagonal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Application.UseCases.School.GetAllSchools
{
    public interface IGetAllSchools : IUseCaseRequest<GetAllSchoolsOutput>
    {
    }
}
