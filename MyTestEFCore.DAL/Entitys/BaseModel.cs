using System.ComponentModel.DataAnnotations;

namespace MyTestEFCore.DAL.Entitys
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
