﻿using System.ComponentModel.DataAnnotations.Schema;
using MVCDay5.Models;

namespace MVCDay5.ViewModels
{
        public class EditStudentViewModel
    {
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public int DeptId { get; set; }
        public string? DepartmentName { get; set; }


    public List<Department> Departments { get; set; } = new List<Department>();
    }
}