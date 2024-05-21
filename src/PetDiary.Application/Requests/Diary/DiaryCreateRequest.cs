using PetDiary.Domain.Enums;

namespace PetDiary.Application.Requests.Diary
{
    public class DiaryCreateRequest
    {
        public long UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DiaryType DiaryType { get; set; }
    }
}
