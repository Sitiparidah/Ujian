using EmployeeManagement.Models.CustomValidators;
using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="First name is required")]
        [StringLength(100,MinimumLength =2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        [EmailDomainValidator(AllowedDomain ="gmail.com")]
        [Required]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
    }

    public enum Gender{
        Male,Female
    }
}