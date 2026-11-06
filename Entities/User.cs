namespace HimeraLab.Entities;

public class User
{
    public int Id { get; set; }
    public string Login { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    
    public int IdRole { get; set; }
    public Role Role { get; set; } = null!;
    public ICollection<Saved> SavedItems { get; set; } = new List<Saved>();
}