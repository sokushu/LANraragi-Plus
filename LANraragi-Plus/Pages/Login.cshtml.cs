using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace LANraragi_Plus.Pages
{
	public class LoginModel(SignInManager<IdentityUser> SignInManager) : PageModel
	{
		/// <summary>
		/// 
		/// </summary>
		[FromForm]
		public string? Username { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[FromForm]
		public string? Password { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public bool WrongPass { get; set; }

		public void OnGet()
		{
		}

		public async Task<IActionResult> OnPost()
		{
			bool result;
			if (result = await LoggedIn())
				return RedirectToPage("/Index");

			WrongPass = !result;

			return Page();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		private async Task<bool> LoggedIn()
		{
			if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
				return false;

			SignInResult signInResult = await SignInManager.PasswordSignInAsync(Username, Password, true, false);

			return signInResult.Succeeded;
		}
	}
}
