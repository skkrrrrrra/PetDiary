using PetDiary.Domain.Abstractions;
using PetDiary.Domain.Attributes;
using PetDiary.Domain.Constants;
using PetDiary.Domain.Entities.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetDiary.Domain.Entities;

[Table(Tables.UserProfiles), Auditable]
public class UserProfile : BaseEntity
{
    [Key]
    [Column(Columns.Id)]
    [ForeignKey(nameof(User))]
    public new long Id { get; set; }
    public virtual User User { get; set; }

    [Column(Columns.Username)]
    public string Username { get; set; }

    [Column(Columns.FirstName)]
    public string FirstName { get; set; }

    [Column(Columns.LastName)]
    public string LastName { get; set; }


    public string Base64ProfileImage { get; set; }
    public string Quote { get; set; }
}
