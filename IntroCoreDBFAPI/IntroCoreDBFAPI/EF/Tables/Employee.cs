using System;
using System.Collections.Generic;

namespace IntroCoreDBFAPI.EF.Tables;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Salary { get; set; }
}
