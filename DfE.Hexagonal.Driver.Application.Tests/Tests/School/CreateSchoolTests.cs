using DfE.Hexagonal.Application.UseCases.School.CreateSchool;
using DfE.Hexagonal.Driver.Application.Tests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Driver.Application.Tests.Tests.School
{
    public class CreateSchoolTests
    {
        [Fact]
        public async void CreateSchool_returns_true_if_created_successfully()
        {
            // arrange

            var repository = SchoolRepositoryTestDoubles.MockReturnsForCreate(true);

            var school = new SchoolInput()
            {
                Id = Guid.NewGuid(),
                Name = "test",
                Description = "test",
                OpenDate = DateTime.Now
            };

            // act

            var sut = new CreateSchool(repository);
            var result = await sut.Handle(school);

            // assert

            Assert.True(result.Success);
        }

        [Fact]
        public async void CreateSchool_returns_false_if_school_is_invalid()
        {
            // arrange

            var repository = SchoolRepositoryTestDoubles.MockReturnsForCreate(false);

            var school = new SchoolInput()
            {
                Id = Guid.NewGuid(),
                Name = "",
                Description = "",
                OpenDate = DateTime.Now
            };

            // act

            var sut = new CreateSchool(repository);
            var result = await sut.Handle(school);

            // assert

            Assert.False(result.Success);
        }
    }
}
