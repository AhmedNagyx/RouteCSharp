﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }

        public int Dept_ID { get; set; }
        public Department Department { get; set; }


        public ICollection<Course_Inst> Course_Instructors { get; set; }
    }
}
