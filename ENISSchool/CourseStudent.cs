using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ENISSchool
{
    class CourseStudent
    {
        [Key]
        public int IDStudent { get; set; }
        [Key]
        public int IDCourse { get; set; }

        public int note { get; set; }

    }
}
