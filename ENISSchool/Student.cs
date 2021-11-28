using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ENISSchool
{
    [Table("StudentEnis")]
    public class Student // bch izid il clé primere wa7dou wa7dou 
    {
        [Key]
        public int StudentID { get; set; }
        [Column("NameStd", TypeName = "ntext")]
        [MaxLength(30)]
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Class { get; set; }
        public Grade Grade  { get; set; }
        public StudentAddress Address { get; set; }
        public IList<Course> courses { get; set; }

       /*
        public class student
        {
            [Key]
            public int StudentId { get; set; }
            [Column("NameStd",TypeName = "ntext")]
            [MaxLength(30)]
            public string Name { get; set; }
        }*/
    }
}
