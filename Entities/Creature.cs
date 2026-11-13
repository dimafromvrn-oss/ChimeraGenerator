namespace HimeraLab.Entities;

public class Creature : BaseEntity
{
    public string Name { get; set; }
    public string Size { get; set; }
    public int AC { get; set; }
    public int HP { get; set; }
    public string HPFormula { get; set; } = null!;
    public float CR { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int ProficiencyBonus { get; set; }
    public Guid IdType { get; set; }
    public ICollection<LanguageCreature> LanguageCreatures { get; set; } = new List<LanguageCreature>();
    public ICollection<SavingThrowCreature> SavingThrowCreatures { get; set; } = new List<SavingThrowCreature>();
    public ICollection<SkillCreature> SkillCreatures { get; set; } = new List<SkillCreature>();
    public ICollection<SpeedCreature> SpeedCreatures { get; set; } = new List<SpeedCreature>();
    public ICollection<ActionCreature> ActionCreatures { get; set; } = new List<ActionCreature>();
    public ICollection<CreatureFeat> CreatureFeats { get; set; } = new List<CreatureFeat>();
    public ICollection<Attack> Attacks { get; set; } = new List<Attack>();
    public ICollection<GenerationTableCreature> GenerationTableCreatures { get; set; } = new List<GenerationTableCreature>();
}