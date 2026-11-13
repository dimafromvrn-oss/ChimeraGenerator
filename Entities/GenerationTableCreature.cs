using System;

namespace HimeraLab.Entities;

public class 
    GenerationTableCreature : BaseEntity
{
    public Guid IdTable { get; set; }
    public Guid IdCreature { get; set; }
    public int RangeMin { get; set; }
    public int RangeMax { get; set; }
}