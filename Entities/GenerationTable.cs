namespace HimeraLab.Entities;

public class GenerationTable
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<GenerationTableCreature> Entries { get; set; } = new List<GenerationTableCreature>();
}