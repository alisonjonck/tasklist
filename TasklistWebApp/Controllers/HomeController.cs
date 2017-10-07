using System.Web.Mvc;
using TasklistWebApp.Helpers;

namespace TasklistWebApp.Controllers
{
	[AuthorizeFor("Home", Models.AccessLevel.TasklistUser)]
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}
