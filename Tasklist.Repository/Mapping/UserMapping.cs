using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Tasklist.Domain.Entity;

namespace Tasklist.Repository.Mapping
{
	public class UserMapping : EntityTypeConfiguration<User>
	{
		public UserMapping()
		{
			ToTable("users");

			HasKey(u => u.Id);

			Property(u => u.Id)
				.HasColumnName("id")
				.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("ia_id") { IsUnique = true }));

			Property(u => u.Email)
				.HasColumnName("user_email");

			Property(u => u.FullName)
				.HasColumnName("user_fullname");

			Property(u => u.Password)
				.HasColumnName("user_password");
		}
	}
}
