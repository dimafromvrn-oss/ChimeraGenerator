namespace HimeraLab.Entities;

public class Skill : BaseEntity
{
    public string Name { get; set; } = null!;
    public string RelatedCharacteristic { get; set; } = null!;
}