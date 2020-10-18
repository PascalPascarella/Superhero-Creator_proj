using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Superhero_Creator2.Models
{
	public class Superhero
	{
		// Primary Key
		[Key]
		public int Id { get; set; }

		[Display(Name ="Hero Name")]
		public string HeroName { get; set; }

		[Display(Name = "Alias")]
		public string Alias { get; set; }

		[Display(Name = "Primary Superpower")]
		public string SuperPowerPrimary { get; set; }

		[Display(Name = "Secondary Superpower")]
		public string SuperPowerSecondary { get; set; }

		[Display(Name = "Catchphrase")]
		public string Catchphrase { get; set; }

	}
}
