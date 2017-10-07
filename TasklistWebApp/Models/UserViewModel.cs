using System.Collections.Generic;
using System.Security.Claims;

namespace TasklistWebApp.Models
{
	public class UserViewModel
	{
		public string FullName { get; set; }

		public string Email { get; set; }

		public IList<Claim> Claims { get; set; }
	}
}