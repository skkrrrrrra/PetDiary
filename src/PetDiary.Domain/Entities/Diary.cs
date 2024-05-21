using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Constants;
using PetDiary.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities
{
    [Table(Tables.Diary)]
    public class Diary : BaseEntity
    {
        [ForeignKey(nameof(UserProfile))]
        [Column(Columns.UserId)]
        public long UserId { get; set; }
        public UserProfile UserProfile { get; set; }


        [Column(Columns.Title)]
        public string Title { get; set; }

        [Column(Columns.Description)]
        public string Description { get; set; }

        [Column(Columns.DiaryType)]
        public DiaryType DiaryType { get; set; }


        public virtual List<Note> Notes { get; set; }
    }
}
