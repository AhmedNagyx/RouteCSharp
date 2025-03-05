using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    [PrimaryKey("Stud_ID", "Course_ID")]
    public class Stud_Course
    {
        public int Stud_ID { get; set; }
        public Student Student { get; set; }

        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public string Grade { get; set; }
    }
}
