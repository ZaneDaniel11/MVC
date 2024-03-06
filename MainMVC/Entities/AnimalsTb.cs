using System;
using System.Collections.Generic;

namespace MainMVC.Entities;

public partial class AnimalsTb
{
    public int AnimalId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;
}
