﻿

using MVCDay5.Models;

namespace MVCDay5.ViewModels
{
    public class DepartmentViewModel
    {
        public int DeptId { get; set; }
        public string? Name { get; set; }
        public List<string> StudentNames { get; set; } = new List<string>();
    }
}