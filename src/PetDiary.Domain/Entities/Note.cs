using PetDiary.Domain.Abstractions;

namespace PetDiary.Domain.Entities
{
    public class Note : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public virtual List<Sticker> Stickers { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
