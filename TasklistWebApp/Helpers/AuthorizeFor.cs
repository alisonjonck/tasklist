using System;
using System.Linq;
using System.Web;
using Mvc = System.Web.Mvc;
using TasklistWebApp.Models;

namespace TasklistWebApp.Helpers
{
	public class AuthorizeForAttribute : Mvc.AuthorizeAttribute
	{
		private readonly string _claimName;
		private readonly int _claimValue;

		public AuthorizeForAttribute(string claimName, AccessLevel claimValue)
		{
			_claimName = claimName;
			_claimValue = (int)claimValue;
		}

		protected override bool AuthorizeCore(HttpContextBase httpContext)
		{
			UserViewModel userSession = httpContext.Session["user_session"] as UserViewModel;

			if (userSession == null)
			{
				// Usuário não autenticado é redirecionado para Login
				httpContext.Response.Redirect("/Conta/Acessar");
				return false;
			}

			var userClaim = userSession.Claims.FirstOrDefault(c => c.Type == _claimName);
			if (userClaim == null)
			{
				// Usuário não possui permissão é redirecionado para Home
				httpContext.Response.Redirect("../#/Home");
				return false;
			}

			if ((int)(Enum.Parse(typeof(AccessLevel), userClaim.Value)) >= _claimValue)
			{
				return true;
			}

			return false;
		}
	}
}