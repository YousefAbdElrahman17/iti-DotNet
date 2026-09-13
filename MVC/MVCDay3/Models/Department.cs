﻿using System.ComponentModel.DataAnnotations;

namespace MVCDay3.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}