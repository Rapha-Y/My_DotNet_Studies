using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_MVC_Course.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Desçription")]
        public string Description { get; set; }
        [Range(1, 10, ErrorMessage = "Out of range value")]
        public int Amount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
