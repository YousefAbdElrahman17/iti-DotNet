﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using MVCDay6.Models;

namespace MVCDay6.ViewModels
{
    public class AddDepartmentViewModel
    {
        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Add Department")]
        [MinLength(2, ErrorMessage = "Name Min Length is 2")]
        [MaxLength(50, ErrorMessage = "Name Max length is 50")]
        public string? Name { get; set; }
    }
}