using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities
{
    public class StickerPack : BaseEntity
    {
        [Column(Columns.Title)]
        public string Title { get; set; }

        public virtual List<Sticker> Stickers { get; set; }
    }
}
