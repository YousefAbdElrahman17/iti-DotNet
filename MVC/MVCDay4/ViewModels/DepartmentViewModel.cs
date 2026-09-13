﻿

using MVCDay4.Models;

namespace MVCDay4.ViewModels
{
    public class DepartmentViewModel
    {
        public int DeptId { get; set; }
        public string? Name { get; set; }
        public List<string> StudentNames { get; set; } = new List<string>();
    }
}