using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Day6Demo.ViewModels
{
    public class EmployeeViewModel
    {
        [Key]
        public int EmployeeId { get; set; }
       public string Name { get; set; } = null!;

        public string Job { get; set; } = null!;

        public string DepartmentName { get; set; } = null!;
        public string? Manager { get; set; }

    }
}
