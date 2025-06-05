using System.ComponentModel.DataAnnotations;

namespace Prototype.Web.Components.Pages
{
	public class RegisterFormData
	{
		[Required]
		[StringLength(20, MinimumLength = 2)]
		public string FirstName { get; set; } = string.Empty;

		[Required, MinLength(1)]
		public string LastName { get; set; } = string.Empty;

		[Required]
		[Range(typeof(DateOnly),"1990-01-01","2012-12-31", ErrorMessage = "Sorry you are not eligible to register!")]
		public DateOnly DoB {  get; set; } = DateOnly.FromDateTime(DateTime.Today);

		[Required]
		[EmailAddress]
		public string EmailAddress { get; set; } = string.Empty;

		[Required, StringLength(20, MinimumLength = 8, ErrorMessage = "Password should have minimum of 8 characters and maximum of 20 characters.")] 
		[RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",ErrorMessage = "Password must contain atleast one uppercase, one lowercase, one digit and one special character.")]
		public string Password { get; set; } = string.Empty;

		[Required]
		[Compare(nameof(RegisterFormData.Password))]
		public string ConfirmPassword { get; set; } = string.Empty;
	}
}
