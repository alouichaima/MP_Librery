using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Librery_ProjectF.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter the title. It is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Title is too short.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the author's name. It is required.")]
        public string Authorname { get; set; }

        public DateTime Releasedate { get; set; }

        [Display(Name = "Category")]
        public int BookCategoryId { get; set; } // Ajout de la propriété BookCategoryId


        

        public virtual BookCategory Category { get; set; }
    }
}
