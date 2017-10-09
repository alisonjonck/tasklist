using System.Data.Entity;
using Tasklist.Domain.Entity;
using Tasklist.Repository.Mapping;

namespace Tasklist.Repository.Context
{
	public class TasklistCoreContext : DbContext
	{
		public TasklistCoreContext()
		{
		}
		public TasklistCoreContext(string nameOrStringConnection) : base(nameOrStringConnection)
		{
			Configuration.ProxyCreationEnabled = true;
			Configuration.LazyLoadingEnabled = true;
		}
		public virtual DbSet<Task> Tasks { get; set; }
		public virtual DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Configurations.Add(new TaskMapping());
			modelBuilder.Configurations.Add(new UserMapping());
		}

	}
}
