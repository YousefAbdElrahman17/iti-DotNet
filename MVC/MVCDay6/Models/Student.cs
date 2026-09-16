﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace MVCDay6.Models
{
    public class Student
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
        [MinLength(3, ErrorMessage = "Email Min Length is 3")]
        [MaxLength(50, ErrorMessage = "Email Max length is 50")]
        public string? Email { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "70t Pass")]
        [MinLength(3, ErrorMessage = "Password Min Length is 3")]
        [MaxLength(20, ErrorMessage = "Password Max length is 20")]
        public string? Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm Pass")]
        [Compare("Password", ErrorMessage = "Confirm Password does not match Password")]
        public string? ConfirmPassword { get; set; }
        
        public int DeptId { get; set; }
        
        [ForeignKey("DeptId")]
        
        public Department? Department { get; set; }
    }
}