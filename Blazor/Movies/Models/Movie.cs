using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models
{
	public class Movie
	{
		public int Id { get; set; }

		[Required]
		[StringLength(32, MinimumLength = 2)]
		[DisplayName("Название")]
		public string Title { get; set; }
		
		[DisplayName("Дата выхода")]
		[Range(typeof(DateOnly), "1895-10-14", "2032-12-31")]
		public DateOnly ReleaseDate { get; set; }
		[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
		[DisplayName("Жанр")]
		public string? Genre { get; set; }
		[DisplayName("Цена")]
		public decimal? Price { get; set; }
	}
}
