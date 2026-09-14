﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay5.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        [NotMapped]
        public string? ConfirmPassword { get; set; }
        
        
        [ForeignKey("DeptId")]
        public int DeptId { get; set; }
        
        public Department? Department { get; set; }
    }
}