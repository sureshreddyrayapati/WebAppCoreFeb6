using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCoreFeb6.Models
{
    [Table("Students")]
    public class Student
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
    }
}
