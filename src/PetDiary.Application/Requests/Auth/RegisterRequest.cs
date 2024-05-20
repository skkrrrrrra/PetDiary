using System.ComponentModel.DataAnnotations;

namespace PetDiary.Application.Requests.Auth
{
	public sealed class RegisterRequest
	{
		[Required]
		public string FirstName { get; set; } = string.Empty;
        [Required]
		public string LastName { get; set; } = string.Empty;
		[Required]
		public string Username { get; set; } = string.Empty;
		[Required]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;
		public string PhoneNumber { get; set; } = string.Empty;
		[Required]
		public string Password { get; set; } = string.Empty;
	}
}
