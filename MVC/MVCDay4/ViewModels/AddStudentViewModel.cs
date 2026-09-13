﻿

using MVCDay4.Models;

namespace MVCDay4.ViewModels
{
    public class AddStudentViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public int DeptId { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();
    }
}