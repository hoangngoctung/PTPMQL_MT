using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models.Entities
{
    [Table("Student")]
    public class Student

    {
        [Key]
        public string StudentId { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
    }
}