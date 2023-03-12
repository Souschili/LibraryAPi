using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTestEFCore.DAL.Entitys
{
    public class Author:BaseModel
    {
        [Required]
        [StringLength(250)]
        public string? FullName { get; set; }
        [Column(TypeName ="date")]
        public DateTime BirthDay { get; set; } 

        public List<Book> Books { get; set; } = new ();
        public AuthorInfo AuthorInfo { get; set; }

    }
}
