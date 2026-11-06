namespace HimeraLab.Entities;

public class CreatureFeat
{
    public int IdCreature { get; set; }
    public Creature Creature { get; set; } = null!;
    public int IdFeat { get; set; }
    public Feat Feat { get; set; } = null!;
    public string FeatType { get; set; } = null!;
}