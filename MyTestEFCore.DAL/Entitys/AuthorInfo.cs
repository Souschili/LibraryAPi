using System.ComponentModel.DataAnnotations.Schema;

namespace MyTestEFCore.DAL.Entitys
{
    public class AuthorInfo : BaseModel
    {
        public string? Country { get; set; }
        public string? City { get; set; }
        
        public string AuthorName { get; set; }
        public Author Author { get; set; }
    }
}
