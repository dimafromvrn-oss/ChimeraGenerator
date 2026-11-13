namespace HimeraLab.Entities;

public class Saved : BaseEntity
{
    public Guid IdUser { get; set; }
    public Guid? IdHybrid { get; set; }
    public Guid? IdBase { get; set; }
    public Guid? IdDonor { get; set; }
}