using System;
using System.Collections.Generic;

namespace IntroCoreDBFAPI.EF.Tables;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
