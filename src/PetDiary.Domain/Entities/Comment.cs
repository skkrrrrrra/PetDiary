using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Constants;
using PetDiary.Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities
{
    [Table(Tables.Comment)]
    public class Comment : BaseEntity
    {
        [Column(Columns.Content)]
        public string Content { get; set; }

        [Column(Columns.NoteId)]
        [ForeignKey(nameof(Note))]
        public long NoteId { get; set; }

        [Column(Columns.WriterId)]
        [ForeignKey(nameof(Writer))]
        public long WriterId { get; set; }

        public UserProfile Writer { get; set; }
        public Note Note { get; set; }
    }
}
