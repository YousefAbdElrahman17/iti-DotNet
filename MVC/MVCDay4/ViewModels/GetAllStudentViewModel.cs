﻿
using MVCDay4.Models;

namespace MVCDay4.ViewModels
{
    public class GetAllStudentsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string? DepartmentName{get; set;}
        public List<Student> Students { get; set; } = new List<Student>();
    }
}