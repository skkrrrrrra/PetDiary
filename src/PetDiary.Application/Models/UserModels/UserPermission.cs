namespace PetDiary.Application.Models.UserModels;

public class UserPermission
{
    public IdNamePair Action { get; set; }
    public IdNamePair Subject { get; set; }
}
