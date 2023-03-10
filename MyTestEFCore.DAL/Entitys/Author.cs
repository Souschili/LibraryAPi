using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTestEFCore.DAL.Entitys
{
    internal class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string FullName { get; set; }
        [Column(TypeName ="date")]
        public DateTime BirthDay { get; set; }
       
    }
}
