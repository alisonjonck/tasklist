using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasklist.Domain.Entity;

namespace Tasklist.Domain.Tests.Entity
{
	[TestClass]
	public class UserTest
	{
		[TestMethod]
		public void TestUserExists()
		{
			var user = new User();
			Assert.IsInstanceOfType(user, typeof(User));
			Assert.IsNotNull(user);

			user.FullName = "Jhon Banana";
			user.Email = "jhon@mail.com";

			Assert.IsNotNull(user.FullName);
			Assert.IsNotNull(user.Email);
		}
	}
}
