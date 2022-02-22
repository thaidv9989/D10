using System.ComponentModel.DataAnnotations;

namespace EFCore.Models
{
    public class StudentModel
    {
        [Key]
        public int stuId { get; set; } 

        public string stuFirstName { get; set; }
        public string stuLastName { get; set; }
        public string stuCity { get; set; }    
        public string stuState { get; set; }
    }
}
