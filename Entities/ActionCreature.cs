using System;

namespace HimeraLab.Entities;

public class ActionCreature : BaseEntity
{
    public Guid IdAction { get; set; }
    public Guid IdCreature { get; set; }
}