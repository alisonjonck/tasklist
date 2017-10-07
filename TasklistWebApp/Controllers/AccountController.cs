using System.Web.Mvc;
using TasklistWebApp.Models;

namespace TasklistWebApp.Controllers
{
	public class AccountController : Controller
	{
		[AllowAnonymous]
		public ActionResult Index(string returnUrl)
		{
			ViewBag.ReturnUrl = returnUrl;

			if (Session["user_session"] != null && Session["user_session"] is UserViewModel)
				return RedirectToAction("Index", "Home", new { returnUrl = returnUrl});

			return View("Login");
		}
	}
}