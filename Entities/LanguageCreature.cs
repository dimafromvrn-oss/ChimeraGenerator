namespace HimeraLab.Entities;

public class LanguageCreature
{
    public int IdLanguage { get; set; }
    public Language Language { get; set; } = null!;
    public int IdCreature { get; set; }
    public Creature Creature { get; set; } = null!;
    public bool CanSpeak { get; set; }
}