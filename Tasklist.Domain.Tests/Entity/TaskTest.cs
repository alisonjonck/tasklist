using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasklist.Domain.Entity;

namespace Tasklist.Domain.Tests.Entity
{
	[TestClass]
	public class TaskTest
	{
		[TestMethod]
		public void TestTaskExists()
		{
			var task = new Task();
			Assert.IsInstanceOfType(task, typeof(Task));
			Assert.IsNotNull(task);

			task.Title = "Do homework";
			task.Status = Enum.TaskStatus.Done;

			Assert.IsNotNull(task.Title);
			Assert.IsNotNull(task.Status);
		}
	}
}
