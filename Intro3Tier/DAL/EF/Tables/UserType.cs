using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class UserType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
