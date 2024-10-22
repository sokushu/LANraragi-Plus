using LANraragi_Plus.APIController.Models;
using Microsoft.AspNetCore.Mvc;

namespace LANraragi_Plus.APIController
{
	public class APIController : Controller
	{
		[HttpGet]
		[Route("/api/categories")]
		public IActionResult Categories()
		{
			return Json(":");
		}

		[HttpGet]
		[Route("/api/info")]
		public IActionResult Info()
		{
			return Json(new APIInfo());
		}
	}
}
