using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Application.UseCases.School.CreateSchool
{
    public class CreateSchoolOutput
    {
        public bool Success { get; set; }
        public Dictionary<string, string> Errors { get; set; }
    }
}
