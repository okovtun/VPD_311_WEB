using System.ComponentModel.DataAnnotations;

namespace Academy.Models
{
	public class Direction
	{
		[Key]
		public byte direction_id { get; set; }
		[Required]
		[StringLength(50, MinimumLength = 5)]
		public string direction_name { get; set; }
		//Navigation properties:
		public List<Group> Groups { get; set; } = new();
		
	}
}
