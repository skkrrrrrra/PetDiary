using PetDiary.Domain.Abstractions;

namespace PetDiary.Domain.Entities
{
    public class PastedSticker : BaseEntity
    {
        public int StickerId { get; set; }
        public int NoteId { get; set; }
        public double XAxisIndentation { get; set; }
        public double YAxisIndentation { get; set; }
        public double RotateCorner { get; set; }

        public virtual Sticker Sticker { get; set; }
    }
}
