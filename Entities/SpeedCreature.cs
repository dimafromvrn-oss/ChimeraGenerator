namespace HimeraLab.Entities;

public class SpeedCreature
{
    public int IdSpeed { get; set; }
    public SpeedType SpeedType { get; set; } = null!;
    public int IdCreature { get; set; }
    public Creature Creature { get; set; } = null!;
    public int Value { get; set; }
}