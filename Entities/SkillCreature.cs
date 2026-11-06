namespace HimeraLab.Entities;

public class SkillCreature
{
    public int IdSkill { get; set; }
    public Skill Skill { get; set; } = null!;
    public int IdCreature { get; set; }
    public Creature Creature { get; set; } = null!;
    public bool DoubleProficiency { get; set; }
}