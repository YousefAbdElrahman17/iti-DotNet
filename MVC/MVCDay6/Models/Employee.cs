﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDay6.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public decimal? Salary { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}