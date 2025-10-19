using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
	public class Group
	{
		[Key]
		public int group_id { get; set; }
		[Required]
		[StringLength(10)]
		public string group_name { get; set; }
		[Required]
		[ForeignKey(nameof(Direction))]   //https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx
		public byte direction { get; set; }
		//Navigation property:
		[Required]
		public Direction Direction { get; set; }
	}
}
