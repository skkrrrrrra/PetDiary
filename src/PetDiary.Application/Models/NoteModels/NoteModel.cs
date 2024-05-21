using PetDiary.Application.Models.Base;
using PetDiary.Application.Models.CommentModels;
using PetDiary.Application.Models.StickerModels;
using PetDiary.Domain.Entities;

namespace PetDiary.Application.Models.NoteModels
{
    public class NoteModel : BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<StickerModel> Stickers { get; set; }
        public List<CommentModel> Comments { get; set; }

        public NoteModel ConvertFromEntity(Note entity)
        {
            return new NoteModel
            {
                Id = entity.Id,
                Title = entity.Title,
                Content = entity.Content,
                Stickers = entity.Stickers?.Select(item => new StickerModel().ConvertFromEntity(item)).ToList() ?? null,
                Comments = entity.Comments?.Select(item => new CommentModel().ConvertFromEntity(item)).ToList() ?? null,
            };
        }

        public Note ConvertToEntity(NoteModel model)
        {
            return new Note();
        }
    }
}
