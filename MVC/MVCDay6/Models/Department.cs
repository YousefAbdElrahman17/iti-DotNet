﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCDay6.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Add Department")]
        [MinLength(2, ErrorMessage = "Name Min Length is 2")]
        [MaxLength(50, ErrorMessage = "Name Max length is 50")]
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
    }
}