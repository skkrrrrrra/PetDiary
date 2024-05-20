using System.ComponentModel.DataAnnotations.Schema;
using PetDiary.Domain.Constants;

namespace PetDiary.Domain.Abstractions;

public abstract class AuditableEntity : BaseEntity
{
	[Column(Columns.Deleted)]
	public bool IsDeleted { get; set; }
}
