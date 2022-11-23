using DfE.Hexagonal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Application.UseCases.School.GetAllSchools
{
    public class SchoolOutput : Model.School
    {
        public static SchoolOutput MapOutput(Model.School school)
        {
            return new SchoolOutput()
            {
                Id = school.Id,
                Name = school.Name,
                Description = school.Description,
                OpenDate = school.OpenDate
            };
        }
    }
}
