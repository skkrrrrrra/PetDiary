using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities
{
    [Table(Tables.UserSettings)]
    public class UserSettings : BaseEntity
    {
        [Column(Columns.UserId)]
        [ForeignKey(nameof(User))]
        public long UserId { get; set; }

        [Column(Columns.Font)]
        public FontType Font { get; set; }

        [Column(Columns.ApplicationTheme)]
        public ApplicationTheme ApplicationTheme{ get; set; }
    
        public virtual UserProfile User { get; set; }
    }
}
public enum FontType
{
}

public enum ApplicationTheme
{

}