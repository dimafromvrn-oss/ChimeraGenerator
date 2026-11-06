namespace HimeraLab.Entities;

public class GenerationTableCreature
{
    public int IdCreature { get; set; }
    public Creature Creature { get; set; } = null!;
    public int IdTable { get; set; }
    public GenerationTable Table { get; set; } = null!;
    
    public int RangeMin { get; set; }
    public int RangeMax { get; set; }
}