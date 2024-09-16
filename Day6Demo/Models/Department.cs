using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Day6Demo.Models
{

    public partial class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Please enter the department name !")]
        [MaxLength(50, ErrorMessage = "please enter less 50 letter !")]
        public string DepartmentName { get; set; } = null!;
        [DisplayName("Manager")]
        public string? DepartmnetManager { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}