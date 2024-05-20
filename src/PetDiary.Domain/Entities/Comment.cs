using PetDiary.Domain.Abstractions;

namespace PetDiary.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }

        public int NoteId { get; set; }
        public int WriterId { get; set; }

        public UserProfile Writer { get; set; }
    }
}
