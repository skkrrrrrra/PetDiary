using PetDiary.Domain.Enums;

namespace PetDiary.Application.Responses.Results
{
    public abstract class Result<T>
    {
        public abstract ResultType ResultType { get; }
        public abstract List<string> Errors { get; }
        public abstract T Data { get; }
    }
}
