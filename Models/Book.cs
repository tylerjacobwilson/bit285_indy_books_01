using System;
using System.ComponentModel.DataAnnotations;

namespace IndyBooks.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string Edition { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Publication Year")]
        public string Year { get; set; }
    }
}
