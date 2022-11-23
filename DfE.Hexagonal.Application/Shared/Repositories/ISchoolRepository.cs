using DfE.Hexagonal.Common.Repository;
using DfE.Hexagonal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Application.Shared.Repositories
{
    public interface ISchoolRepository : IRepository<Guid, School>
    {
    }
}
