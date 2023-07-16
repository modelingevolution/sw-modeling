using FluentValidation.Results;

namespace Starter.Common.Validation
{
    interface IValidatorAdapter
    {
        ValidationResult Validate(object u);
    }
    interface IValidatorAdapter<T>  : IValidatorAdapter {}
}