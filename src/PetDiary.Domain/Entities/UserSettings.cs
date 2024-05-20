using PetDiary.Domain.Abstractions;

namespace PetDiary.Domain.Entities
{
    public class UserSettings : BaseEntity
    {
        public FontType Font { get; set; }
        public ApplicationTheme ApplicationTheme{ get; set; }
    }
}
public enum FontType
{
}

public enum ApplicationTheme
{

}