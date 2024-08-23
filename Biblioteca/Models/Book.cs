using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public string CoverImage { get; set; }
        [Required]
        public string Status { get; set; }
        public virtual  Author Author { get; set; }
        public virtual Genre Genre { get; set; }
    }
   
}