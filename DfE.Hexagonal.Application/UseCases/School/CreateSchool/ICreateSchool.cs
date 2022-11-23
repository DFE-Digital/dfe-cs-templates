using DfE.Hexagonal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Application.UseCases.School.CreateSchool
{
    public interface ICreateSchool : IUseCase<SchoolInput, CreateSchoolOutput>
    {
    }
}
