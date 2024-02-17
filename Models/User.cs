using System.ComponentModel.DataAnnotations;
namespace MyTask.Models
{
    public class User 
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        //public ICollection<Task> Tasks { get; set; }

    }
}
