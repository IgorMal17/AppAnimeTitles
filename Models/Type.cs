using System;
using System.Collections.Generic;

namespace AppAnimeTitles.Models;

public partial class Type
{
    public short Id { get; set; }

    public string TypeName { get; set; } = null!;

    //Навигационные свойства
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
