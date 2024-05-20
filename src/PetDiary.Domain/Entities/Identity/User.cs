using Microsoft.AspNetCore.Identity;
namespace PetDiary.Domain.Entities.Identity;

public class User : IdentityUser<long>
{
	public virtual UserProfile UserProfile { get; set; }

	public virtual IEnumerable<Role> Roles { get; set; }
}
