using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Tasklist.Domain.Entity;

namespace Tasklist.Repository.Mapping
{
	public class TaskMapping : EntityTypeConfiguration<Task>
	{
		public TaskMapping()
		{
			ToTable("tasks");

			HasKey(t => t.Id);

			Property(t => t.Id)
				.HasColumnName("id")
				.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("ia_id") { IsUnique = true }));

			Property(t => t.Title)
				.HasColumnName("task_title");

			Property(t => t.Status)
				.HasColumnName("task_status");
		}
	}
}
