using System;
using System.Collections.Generic;

namespace IntroCoreDBFAPI.EF.Tables;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? DeptId { get; set; }

    public virtual Department? Dept { get; set; }
}
