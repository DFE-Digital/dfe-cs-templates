using DfE.Hexagonal.Application.Shared.Repositories;
using DfE.Hexagonal.Model;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Driver.Application.Tests.TestDoubles
{
    public class SchoolRepositoryTestDoubles
    {
        public static ISchoolRepository Mock()
        {
            return Substitute.For<ISchoolRepository>();
        }

        public static ISchoolRepository MockFor(IEnumerable<School> schools)
        {
            var mock = Mock();

            mock.GetAll().Returns(schools);

            return mock;
        }

        public static ISchoolRepository MockReturnsForCreate(bool returnValue)
        {
            var mock = Mock();

            mock.Create(Arg.Any<School>()).Returns(returnValue);

            return mock;
        }
    }
}
