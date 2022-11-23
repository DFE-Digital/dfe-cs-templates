using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Common.Validation
{
    public interface IValidatable
    {
        ValidationResult Validate();
    }
}
