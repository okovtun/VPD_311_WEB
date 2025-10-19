using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academy.Models;

namespace Academy.Data
{
    public class AcademyContext : DbContext
    {
        public AcademyContext (DbContextOptions<AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<Academy.Models.Discipline> Disciplines { get; set; } = default!;
        public DbSet<Academy.Models.Direction> Directions { get; set; } = default!;
        public DbSet<Academy.Models.Group> Groups { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//https://learn.microsoft.com/en-us/ef/core/modeling/relationships/foreign-and-principal-keys
            modelBuilder.Entity<Direction>()
                .HasMany(d => d.Groups)
                .WithOne(g => g.Direction)
                .HasForeignKey(g => g.direction);

			modelBuilder.Entity<Group>()
                .HasOne(g => g.Direction)
                .WithMany(d => d.Groups)
                //.HasForeignKey(g => g.direction)
                ;


			//https://learn.microsoft.com/en-us/ef/core/modeling/relationships/foreign-and-principal-keys
		}
	}
}
