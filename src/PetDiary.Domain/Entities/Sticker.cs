using PetDiary.Domain.Abstractions;

namespace PetDiary.Domain.Entities
{
    public class Sticker : BaseEntity
    {
        public int StickerPackId { get; set; }
        public string Base64Image { get; set; }
    }
}
