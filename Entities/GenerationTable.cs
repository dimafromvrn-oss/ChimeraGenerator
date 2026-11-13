namespace HimeraLab.Entities;

public class GenerationTable : BaseEntity
{
    public string Name { get; set; } = null!;
    public ICollection<GenerationTableCreature> Entries { get; set; } = new List<GenerationTableCreature>();
}