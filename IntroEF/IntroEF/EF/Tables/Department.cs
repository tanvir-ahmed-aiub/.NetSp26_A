using System;
using System.Collections.Generic;

namespace IntroEF.EF.Tables;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
