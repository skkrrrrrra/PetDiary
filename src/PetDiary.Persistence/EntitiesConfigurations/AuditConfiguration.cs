using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetDiary.Domain.Entities.Audit;

namespace PetDiary.Persistence.EntitiesConfigurations;

public class AuditConfiguration : IEntityTypeConfiguration<Audit>
{
	public AuditConfiguration()
	{
	}

	public void Configure(EntityTypeBuilder<Audit> builder)
	{
		builder.ToTable("audits");
		builder.HasMany<AuditMetaData>()
			.WithOne()
			.HasForeignKey(p => p.Id);
	}
}
