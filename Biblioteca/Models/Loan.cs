using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Book")]
        public int BookID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [Required]
        public DateTime LoanDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
        [Required]
        public string Status { get; set; }
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }

    
   
}