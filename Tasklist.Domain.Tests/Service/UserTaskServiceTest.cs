using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasklist.Domain.Entity;
using Tasklist.Domain.Enum;
using Tasklist.Domain.Service;

namespace Tasklist.Domain.Tests.Service
{
	[TestClass]
	public class UserTaskServiceTest
	{
		private User user;
		private Task task;

		[TestInitialize]
		public void SetUp()
		{
			user = new User();
			task = new Task();
		}

		[TestMethod]
		public void TestUserCanAddNewTask()
		{
			var result = UserTaskService.AddTask(user, task);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void TestUserCanChangeTaskStatusToDone()
		{
			var result = UserTaskService.ChangeTaskStatus(user, task, TaskStatus.Done);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void TestUserCanChangeTaskStatusToPending()
		{
			var result = UserTaskService.ChangeTaskStatus(user, task, TaskStatus.Pending);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void TestUserCanUpdateTaskTitle()
		{
			Task result = UserTaskService.UpdateTaskTitle(user, task, "Buy new shirts");

			Assert.IsNotNull(result);
			Assert.AreEqual("Buy new shirts", result.Title);
		}

		[TestMethod]
		public void TestUserCanDeleteTask()
		{
			bool result = UserTaskService.DeleteTask(user, task);
			Assert.IsTrue(result);
		}
	}
}
