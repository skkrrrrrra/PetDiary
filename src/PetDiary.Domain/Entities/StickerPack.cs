using PetDiary.Domain.Abstractions;

namespace PetDiary.Domain.Entities
{
    public class StickerPack : BaseEntity
    {
        public string Title { get; set; }
        public virtual List<Sticker> Stickers { get; set; }
    }
}
