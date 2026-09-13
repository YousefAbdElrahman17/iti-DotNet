﻿using System.ComponentModel.DataAnnotations.Schema;
using MVCDay4.Models;

namespace MVCDay4.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string? DepartmentName{get; set;}
    }
}