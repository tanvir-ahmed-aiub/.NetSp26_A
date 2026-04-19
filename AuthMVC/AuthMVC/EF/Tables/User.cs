using System;
using System.Collections.Generic;

namespace AuthMVC.EF.Tables;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Type { get; set; }

    public virtual UserType TypeNavigation { get; set; } = null!;
}
