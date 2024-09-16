﻿using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string Job { get; set; } = null!;

    public decimal Salary { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public int? DepartId { get; set; }

    public virtual Department? Depart { get; set; }
}
