using Microsoft.AspNetCore.Identity;
using PetDiary.Domain.Enums;

namespace PetDiary.Application.Responses.Results
{
    public class InvalidResult<T> : Result<T>
    {
        private string _error;
        private List<IdentityError> _errorList;
        public InvalidResult(string error)
        {
            _error = error;
        }
        public InvalidResult(List<IdentityError> errors)
        {
            _errorList = errors;
        }
        public override ResultType ResultType => ResultType.Invalid;

        public override List<string> Errors => new List<string> { _error ?? "The input was invalid." };

        public override T Data => default;
    }
}
