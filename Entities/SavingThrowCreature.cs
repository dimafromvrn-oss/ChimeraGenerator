namespace HimeraLab.Entities;

public class SavingThrowCreature
{
    public int IdSave { get; set; }
    public SavingThrow SavingThrow { get; set; } = null!;
    public int IdCreature { get; set; }
    public Creature Creature { get; set; } = null!;
}