using PetDiary.Application.Models.UserModels;

namespace PetDiary.Application.Responses.Auth;

public sealed class LoginResponse
{
	public string Token { get; set; } = string.Empty;
	public UserProfileModel UserData { get; set; }
}
