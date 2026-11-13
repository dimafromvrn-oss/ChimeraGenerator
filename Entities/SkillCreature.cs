namespace HimeraLab.Entities;

public class SkillCreature : BaseEntity
{
    public Guid IdSkill { get; set; }
    public Guid IdCreature { get; set; }
    public bool DoubleProficiency { get; set; }
}