using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest.Models
{
    public class Student
    {
        [Range(0, 12300)]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public int Age { get; set; }
        
        [Range(0.0, 10.0)]
        public double Score { get; set; }
        public bool IsGettingTuition { get; set; }
        public string City { get; set; }
    }
}
