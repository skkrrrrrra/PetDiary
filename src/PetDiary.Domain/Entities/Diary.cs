using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Constants;
using PetDiary.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities
{
    public class Diary : BaseEntity
    {
        [Column(Columns.Title)]
        public string Title { get; set; }

        [Column(Columns.Description)]
        public string Description { get; set; }

        [Column(Columns.DiaryType)]
        public DiaryType DiaryType { get; set; }
    }
}
