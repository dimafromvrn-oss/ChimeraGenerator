namespace HimeraLab.Entities;

public class CreatureFeat : BaseEntity
{
    public Guid IdCreature { get; set; }
    public Guid IdFeat { get; set; }
    public string FeatType { get; set; } = null!;
}