using DfE.Hexagonal.Application.Shared.Repositories;
using DfE.Hexagonal.Common;
using DfE.Hexagonal.Common.Validation;
using DfE.Hexagonal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Application.UseCases.School.CreateSchool
{
    public class CreateSchool : ICreateSchool
    {
        private readonly ISchoolRepository _schoolRepository;

        public CreateSchool(ISchoolRepository repository)
        {
            _schoolRepository = repository;
        }

        public async Task<CreateSchoolOutput> Handle(SchoolInput input)
        {
            var output = new CreateSchoolOutput();

            ValidationResult validation = input.Validate();

            if (validation.IsValid)
            {
                _schoolRepository.Create(SchoolInput.MapInput(input));
                output.Success = true;
            }
            else
            {
                output.Success = false;
                output.Errors = validation.Errors;
            }

            return output;
        }
    }
}
