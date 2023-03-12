using System.ComponentModel.DataAnnotations;

namespace MyTestEFCore.DAL.Entitys
{
    public class Book:BaseModel
    {
        [Required]
        [StringLength(250)]
        public string? BookName { get; set; }

        [Required]
        public int Pages { get; set; }

        public string AuthorName { get; set; }
        public Author? Author { get; set; }

    }
}
