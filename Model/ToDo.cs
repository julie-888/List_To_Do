using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace List_To_Do.Model
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Write the title")]

        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("CategoryIdFK")]
        public int CategoryId { get; set; }
    }

}
