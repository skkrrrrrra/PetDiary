using PetDiary.Domain.Enums;

namespace PetDiary.Domain.Entities.Results
{
    public class SuccessResult<T> : Result<T>
    {
        private readonly T _data;
        public SuccessResult(T data)
        {
            _data = data;
        }
        public override ResultType ResultType => ResultType.Success;

        public override List<string> Errors => new List<string>();

        public override T Data => _data;
    }
}
