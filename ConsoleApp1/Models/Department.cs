using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string? DepartmnetManager { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
