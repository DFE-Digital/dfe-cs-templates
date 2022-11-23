using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Common.Repository
{
    public interface IRepository<Tid, Tentity>
    {
        bool Create(Tentity entity);   

        bool Update(Tentity entity);

        bool Delete(Tentity entity);

        Tentity GetById(Tid id);

        IEnumerable<Tentity> GetAll();

        IEnumerable<Tentity> GetAll(params Tid[] keys);  
    }
}
