using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Template.Domain.Entities.Identity;

public class UserClaim : IdentityUserClaim<long>
{

}
