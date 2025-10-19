using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Discipline
	{
		[Key]
		public short discipline_id { get; set; }
		[Required]
		public string discipline_name { get; set; }
		[Required]
		//https://learn.microsoft.com/en-us/ef/core/modeling/entity-properties?tabs=data-annotations%2Cwith-nrt
		[Column(TypeName = "tinyint")]
		public short number_of_lessons { get; set; }
	}
}
