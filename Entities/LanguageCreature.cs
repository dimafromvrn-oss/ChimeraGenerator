namespace HimeraLab.Entities;

public class LanguageCreature : BaseEntity
{
    public Guid IdLanguage { get; set; }
    public Guid IdCreature { get; set; }
    public bool CanSpeak { get; set; }
}