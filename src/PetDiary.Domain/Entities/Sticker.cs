using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities
{
    public class Sticker : BaseEntity
    {
        [Column(Columns.StickerPackId)]
        public int StickerPackId { get; set; }

        [Column(Columns.Base64Image)]
        public string Base64Image { get; set; }
    }
}
