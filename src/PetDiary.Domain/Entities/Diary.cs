using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Enums;

namespace PetDiary.Domain.Entities
{
    public class Diary : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DiaryType DiaryType { get; set; }
    }
}
