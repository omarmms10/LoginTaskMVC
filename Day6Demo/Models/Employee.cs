using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Day6Demo.Models
{

    public partial class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Please enter your name !")]
        [MaxLength(50, ErrorMessage = "Must enter less than 50 letter !")]
        public string EmployeeName { get; set; } = null!;

        public string Job { get; set; } = null!;
        [Required(ErrorMessage = "Please enter your salary !")]
        public decimal Salary { get; set; }

        public string? Address { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [ForeignKey(nameof(Depart))]
        public int? DepartId { get; set; }

        public virtual Department? Depart { get; set; }
    }
}