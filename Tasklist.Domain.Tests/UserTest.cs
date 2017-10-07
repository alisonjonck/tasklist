using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasklist.Domain.Entity;

namespace Tasklist.Domain.Tests
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
		}
	}
}
