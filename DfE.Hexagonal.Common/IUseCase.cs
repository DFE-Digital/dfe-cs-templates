using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Common
{
    public interface IUseCase<Tin, Tout>
    {
        Task<Tout> Handle(Tin input);
    }
}
