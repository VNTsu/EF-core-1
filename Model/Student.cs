using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assign1.Model
{
    public class Student
    {
        [Key]
        public string Id { get; set; }  
        public string FirtName { get; set; }  
        public string LastName { get; set; }  
        public string City { get; set; }  
        public string State { get; set; }  
    }
}