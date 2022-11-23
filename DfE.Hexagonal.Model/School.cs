using DfE.Hexagonal.Common.Validation;

namespace DfE.Hexagonal.Model
{
    public class School : IValidatable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; set; }

        public ValidationResult Validate()
        {
            bool isValid = true;
            var errors = new Dictionary<string, string>();

            if (Id.Equals(Guid.Empty))
            {
                isValid = false;
                errors.Add("Id", "Id must have a value");
            }

            if (String.IsNullOrEmpty(Name))
            {
                isValid = false;
                errors.Add("Name", "Name must have a value");
            }

            if (String.IsNullOrEmpty(Description))
            {
                isValid = false;
                errors.Add("Description", "Description must have a value");
            }

            return new ValidationResult(isValid, errors);
        }
    }
}