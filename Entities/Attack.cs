namespace HimeraLab.Entities;

public class Attack : BaseEntity
{
    public int AttackBonus { get; set; }
    public string Damage { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Characteristic { get; set; } = null!;
    public string Name { get; set; } = null!;
    
    public Guid IdCreature { get; set; }
    public Guid? IdDamage { get; set; }
}