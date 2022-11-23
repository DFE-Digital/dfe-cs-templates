using DfE.Hexagonal.Application.Shared.Repositories;
using DfE.Hexagonal.Model;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Driven.InMemory
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly InMemoryContext _memoryContext;

        public SchoolRepository(InMemoryContext memoryContext)
        {
            _memoryContext = memoryContext;
        }

        public bool Create(School entity)
        {
            _memoryContext.Schools.Add(entity);
            return true;
        }

        public bool Delete(School entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<School> GetAll()
        {
            return _memoryContext.Schools;
        }

        public IEnumerable<School> GetAll(params Guid[] keys)
        {
            throw new NotImplementedException();
        }

        public School GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(School entity)
        {
            throw new NotImplementedException();
        }
    }
}
