using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }     
        [ForeignKey("Books")]
        public int BookId { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public virtual Book Books { get; set; }
        public virtual User Users { get; set; }
    }
    
}