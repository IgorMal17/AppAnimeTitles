using System;
using System.Collections.Generic;

namespace AppAnimeTitles.Models;

public partial class Status
{
    public short Id { get; set; }

    public string StatusName { get; set; } = null!;

    //Навигационные свойства
    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
}
