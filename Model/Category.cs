using System.ComponentModel.DataAnnotations;

namespace List_To_Do.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public ICollection<ToDo> ToDos { get; set; }
    }
}
