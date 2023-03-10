using System.ComponentModel.DataAnnotations;

namespace MyTestEFCore.DAL.Entitys
{
    internal class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string? BookName { get; set; }

        [Required]
        public int Pages { get; set; }

    }
}
