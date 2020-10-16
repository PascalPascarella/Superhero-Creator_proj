using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Superhero_Creator2.Models;

namespace Superhero_Creator2.Data
{
	// Represents DB inside application
	public class ApplicationDbContext : IdentityDbContext
	{
		// Table in DB
		public DbSet<Superhero> Superheroes { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
				: base(options)
		{
		}
	}
}
