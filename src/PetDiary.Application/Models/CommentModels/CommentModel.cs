using PetDiary.Application.Models.Base;
using PetDiary.Application.Models.UserModels;
using PetDiary.Domain.Entities;

namespace PetDiary.Application.Models.CommentModels
{
    public class CommentModel : BaseModel
    {
        public string Content { get; set; }
        public UserProfileModel Writer { get; set; }

        public CommentModel ConvertFromEntity(Comment entity)
        {
            return new CommentModel
            {
                Id = entity.Id,
                Content = entity.Content,
                Writer = new UserProfileModel().ConvertFromEntity(entity.Writer)
            };
        }

        public Comment ConvertToEntity(CommentModel model)
        {
            return new Comment();
        }
    }
}
