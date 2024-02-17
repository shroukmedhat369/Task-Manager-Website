using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTask.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        public string Description { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
