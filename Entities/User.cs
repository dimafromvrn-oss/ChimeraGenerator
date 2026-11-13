using System;
using System.Collections.Generic;

namespace HimeraLab.Entities;

public class User : BaseEntity
{
    public string Login { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    
    public Guid IdRole { get; set; }
    public ICollection<Saved> SavedItems { get; set; } = new List<Saved>();
}