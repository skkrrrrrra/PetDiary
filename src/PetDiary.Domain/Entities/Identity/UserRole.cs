using Microsoft.AspNetCore.Identity;
using PetDiary.Domain.Entities.Identity;

namespace PetDiary.Domain.Entities.Identity;

public class UserRole : IdentityUserRole<long>
{
	public virtual User User { get; set; }
	public virtual Role Role { get; set; }
}
