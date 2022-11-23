using DfE.Hexagonal.Application.UseCases.School.GetAllSchools;
using DfE.Hexagonal.Driver.Application.Tests.TestDoubles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Driver.Application.Tests.Tests.School
{
    public class GetAllSchoolTests
    {
        [Fact]
        public async void GetAllSchools_returns_a_list_of_schools()
        {
            // arrange

            var repository = SchoolRepositoryTestDoubles.MockFor(new List<SchoolOutput>()
            {
                new SchoolOutput()
                {
                    Id = Guid.NewGuid(),
                    Name = "test",
                    Description = "test",
                    OpenDate = DateTime.Now
                },
                new SchoolOutput()
                {
                    Id = Guid.NewGuid(),
                    Name = "test2",
                    Description = "test2",
                    OpenDate = DateTime.Now
                }
            });

            // act

            var sut = new GetAllSchools(repository);
            var result = await sut.Handle();

            // assert

            Assert.Equal(2, result.Schools.Count());
        }
    }
}
