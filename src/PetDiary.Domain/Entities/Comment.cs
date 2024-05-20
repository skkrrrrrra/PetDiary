using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Constants;
using PetDiary.Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities
{
    public class Comment : BaseEntity
    {
        [Column(Columns.Content)]
        public string Content { get; set; }

        [Column(Columns.NoteId)]
        [ForeignKey(nameof(Note))]
        public int NoteId { get; set; }

        [Column(Columns.WriterId)]
        [ForeignKey(nameof(Writer))]
        public int WriterId { get; set; }

        public UserProfile Writer { get; set; }
        public Note Note { get; set; }
    }
}
