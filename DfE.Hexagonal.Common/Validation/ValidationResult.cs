using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfE.Hexagonal.Common.Validation
{
    /// <summary>
    /// contains a validation result and a dictionary of errors, if applicable
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// is the thing valid?
        /// </summary>
        public bool IsValid { get; }

        /// <summary>
        /// key/error pairs for each member of an IValidatable
        /// </summary>
        public Dictionary<string, string> Errors { get; }

        public ValidationResult(bool isValid, Dictionary<string, string> errors)
        {
            IsValid = isValid;
            Errors = errors;
        }
    }
}
