using LANraragi_Plus.APIController.Models;
using Microsoft.AspNetCore.Mvc;

namespace LANraragi_Plus.APIController
{
	public class APISearchController : Controller
	{
		[Route("/api/search/random")]
		public IActionResult Random(string? filter, string? category, int? count)
		{
			return Json(new APISearchRandom());
		}

		[Route("/api/search")]
		public IActionResult Search()
		{
			return Json(new APISearch());
		}

		[Route("/search")]
		public IActionResult SearchIndex()
		{
			return Json(new APISearch());
		}
	}
}
