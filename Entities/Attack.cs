namespace HimeraLab.Entities;

public class Attack
{
    public int Id { get; set; }
    public int AttackBonus { get; set; }
    public string Damage { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Characteristic { get; set; } = null!;
    public string Name { get; set; } = null!;
    
    public int IdCreature { get; set; }
    public Creature Creature { get; set; } = null!;
    
    public int? IdDamage { get; set; } 
    public DamageType? DamageType { get; set; }
}