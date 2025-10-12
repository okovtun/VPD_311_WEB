using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhatIsMigration.Models
{
	public class Human
	{
		public int Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateOnly BirthDate { get; set; }
	}
}
