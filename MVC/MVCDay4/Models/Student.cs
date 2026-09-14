﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay4.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        
        [ForeignKey("DeptId")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}