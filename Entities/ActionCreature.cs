namespace HimeraLab.Entities;

public class ActionCreature
{
    public int IdAction { get; set; }
    public Action Action { get; set; } = null!;
    public int IdCreature { get; set; }
    public Creature Creature { get; set; } = null!;
}