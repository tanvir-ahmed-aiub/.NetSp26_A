using System;
using System.Collections.Generic;

namespace IntroDTO.EF.Tables;

public partial class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Did { get; set; }

    public virtual Department DidNavigation { get; set; } = null!;
}
