﻿

using MVCDay6.Models;

namespace MVCDay6.ViewModels
{
    public class DepartmentViewModel
    {
        public int DeptId { get; set; }
        public string? Name { get; set; }
        public List<string> StudentNames { get; set; } = new List<string>();
    }
}