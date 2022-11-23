using DfE.Hexagonal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Driven.InMemory
{
    public class InMemoryContext
    {
        public ICollection<School> Schools;

        public InMemoryContext()
        {
            Schools = new List<School>();
        }
    }
}
