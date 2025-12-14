using System;
using System.Collections.Generic;

namespace IntroCoreDBFAPI.EF.Tables;

public partial class Registration
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;
}
