using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoUniversity.Models
{
	public class Course
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int CourseID { get; set; }
		public string Title { get; set; }
		public int Credits { get; set; }

		//TODO:Navigation properties.
		ICollection<Enrollment> Enrollments { get; set; }
	}
}
