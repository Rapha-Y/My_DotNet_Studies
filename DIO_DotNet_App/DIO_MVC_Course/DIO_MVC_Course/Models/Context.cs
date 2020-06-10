using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DIO_MVC_Course.Models
{
	public class Context: DbContext
	{
		public DbSet<Category> Categories { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MVCCourse;Integrated Security=True");
		}
	}
}
