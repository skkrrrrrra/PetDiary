using PetDiary.Application.Models.Base;
using PetDiary.Domain.Entities;

namespace PetDiary.Application.Models.UserModels;

public class UserProfileModel : BaseModel
{
    public string FirstName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Base64ProfileImage { get; set; } = string.Empty;
    public string Quote { get; set; } = string.Empty;

    public UserProfileModel ConvertFromEntity(UserProfile entity)
    {
        return new UserProfileModel
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            Username = entity.Username,
            Base64ProfileImage = entity.Base64ProfileImage,
            Quote = entity.Quote,
        };
    }

    public UserProfile ConvertToEntity(UserProfileModel model)
    {
        return new UserProfile();
    }
}
