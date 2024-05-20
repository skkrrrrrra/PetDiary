using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PetDiary.Domain.Constants;

namespace PetDiary.Domain.Abstractions;

public abstract class BaseEntity
{
	[Key]
	[Column(Columns.Id)]
	public long Id { get; set; }
}
