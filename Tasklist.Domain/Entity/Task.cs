using Tasklist.Domain.Enum;

namespace Tasklist.Domain.Entity
{
	public class Task
	{
		public string Title { get; set; }
		public TaskStatus Status { get; set; }
	}
}
