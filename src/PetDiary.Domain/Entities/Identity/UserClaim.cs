using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace PetDiary.Domain.Entities.Identity;

public class UserClaim : IdentityUserClaim<long>
{

}
