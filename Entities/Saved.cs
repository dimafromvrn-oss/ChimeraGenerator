namespace HimeraLab.Entities;

public class Saved
{
    public int Id { get; set; }
    public int IdUser {get; set;}
    public User User { get; set; } = null!;
    public int? IdHybrid { get; set; }
    public Creature? Hybrid { get; set; }
    public int? IdBase { get; set; }
    public Creature? Base { get; set; }
    public int? IdDonor { get; set; }
    public Creature? Donor { get; set; }
}