using Tasklist.Domain.Entity;
using Tasklist.Domain.Enum;
using Tasklist.Domain.Interface.Service;

namespace Tasklist.Domain.Service
{
	public class UserTaskService: IUserTaskService
	{
		public static bool AddTask(User user, Task task)
		{
			return true;
		}

		public static bool ChangeTaskStatus(User user, Task task, TaskStatus newStatus)
		{
			return true;
		}

		public static Task UpdateTaskTitle(User user, Task task, string newTitle)
		{
			task.Title = newTitle;
			return task;
		}

		public static bool DeleteTask(User user, Task task)
		{
			return true;
		}
	}
}
