using PetDiary.Application.Models.Base;
using PetDiary.Domain.Entities;

namespace PetDiary.Application.Models.StickerModels
{
    public class StickerModel : BaseModel
    {
        public string? Base64Image { get; set; }
        public double? XAxisIndentation { get; set; }
        public double? YAxisIndentation { get; set; }
        public double? RotateCorner { get; set; }

        public StickerModel ConvertFromEntity(PastedSticker pastedSticker)
        {
            return new StickerModel
            {
                Id = pastedSticker.StickerId,
                Base64Image = pastedSticker.Sticker.Base64Image,
                RotateCorner = pastedSticker.RotateCorner,
                XAxisIndentation = pastedSticker.XAxisIndentation,
                YAxisIndentation = pastedSticker.YAxisIndentation,
            };
        }

        public PastedSticker ConvertToEntity(StickerModel model)
        {
            return new PastedSticker();
        }
    }
}
