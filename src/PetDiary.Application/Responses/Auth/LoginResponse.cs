using PetDiary.Application.Models.User;

namespace PetDiary.Application.Responses.Auth;

public sealed class LoginResponse
{
	public string Token { get; set; } = string.Empty;
	public UserData UserData { get; set; }
}
