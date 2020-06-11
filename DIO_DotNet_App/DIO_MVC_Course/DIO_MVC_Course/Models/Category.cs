using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_MVC_Course.Models
{
	public class Category
	{
		public int id { get; set; }
		[Display(Name = "Desçription")]
		[Required(ErrorMessage = "The description field is mandatory")]
		public string Description { get; set; }
	}
}
