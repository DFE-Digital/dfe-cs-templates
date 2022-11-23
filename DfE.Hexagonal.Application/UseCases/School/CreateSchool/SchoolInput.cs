using DfE.Hexagonal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Application.UseCases.School.CreateSchool
{
    public class SchoolInput : Model.School
    {
        public static Model.School MapInput(SchoolInput input)
        {
            return new Model.School()
            {
                Id = input.Id,
                Name = input.Name,
                Description = input.Description,
                OpenDate = input.OpenDate
            };
        }
    }
}
