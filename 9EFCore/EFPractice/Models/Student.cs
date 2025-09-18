using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFPractice.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName="Varchar(50)")]
        public string Name { get; set; }
        public int RollNo { get; set; }
        [Column("StudentGender", TypeName ="Varchar(10)")]
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Standard { get; set; }
    }
}
