namespace HimeraLab.Entities;

public class SpeedCreature : BaseEntity
{
    public Guid IdSpeed { get; set; }
    public Guid IdCreature { get; set; }
    public int Value { get; set; }
}