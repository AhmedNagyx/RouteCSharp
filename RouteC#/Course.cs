using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC_
{
    public class Course
    {
        //annotation
        [Key]
        public int Id { get; set; }
        public int Duration { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public int Top_Id { get; set; }
    }
}
