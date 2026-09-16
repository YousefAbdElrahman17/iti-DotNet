﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MVCDay6.Models;

namespace MVCDay6.ViewModels
{
    public class EditStudentViewModel
    {
        public int Id { get; set; }

        [DisplayName("Student Name")]
        [Required(ErrorMessage = "Add Name Ya5oya")]
        [MinLength(3, ErrorMessage = "Name Min Length is 3")]
        [MaxLength(50, ErrorMessage = "Name Max length is 50")]
        public string? Name { get; set; }

        [Range(15, 60, ErrorMessage = "Age must be between 15 and 60")]
        public int Age { get; set; }

        [StringLength(40, ErrorMessage = "Address must be between 3 and 40", MinimumLength = 3)]
        public string? Address { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "7ot Email tmam")]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "70t Pass")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Choose Department")]
        public int DeptId { get; set; }
        
        public string? DepartmentName { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();
    }
}