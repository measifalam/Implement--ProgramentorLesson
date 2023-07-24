using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstASPCore.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("StudentName",TypeName ="varchar(100)")]
        public string Name { get; set; }
        [Column("Gender", TypeName = "varchar(100)")]
        public string Gender { get; set; }
        public int Age { get; set;}

        public int Standard { get; set;}
    }
}
