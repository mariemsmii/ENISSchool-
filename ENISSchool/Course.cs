using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENISSchool
{
    public class Course // hedhi il entity thenya illi bch tetzadelna fil base 
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int HoursNumber { get; set; }
        public int coefficient { get; set; }
        public IList<Student> Students { get; set; }
    }
}
