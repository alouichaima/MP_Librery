using System.ComponentModel.DataAnnotations;

namespace Librery_ProjectF.Models
{
    public class BookCategory
    {
        [Key]
        public int BookCategoryId { get; set; }

        [Display (Name ="Category")]
        public string BookCategoryName { get; set; }
    }
}
