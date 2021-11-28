using System;
using System.Collections.Generic;
using System.Text;

namespace ENISSchool
{
    public class Grade
    {
        public int Id { get; set; }
        public int classNumber { get; set; }
        public  string Speciallity { get; set; }
        public IList<Student> Students { get; set; }

    }
}
