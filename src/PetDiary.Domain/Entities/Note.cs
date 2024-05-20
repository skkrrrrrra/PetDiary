using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities
{
    [Table(Tables.Note)]
    public class Note : BaseEntity
    {
        [Column(Columns.Title)]
        public string Title { get; set; }

        [Column(Columns.Content)]
        public string Content { get; set; }

        [Column(Columns.DiaryId)]
        [ForeignKey(nameof(Diary))]
        public long DiaryId { get; set; }


        public virtual Diary Diary { get; set; }
        public virtual List<Sticker> Stickers { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
